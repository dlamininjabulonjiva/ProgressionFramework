using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBuilding.TestInfrastructure
{
  public static class ObjectExtensions
#pragma warning restore IDE1006 // Naming Styles
  {
    private static readonly Random _rng = new Random();

    public static Task<T> DefaultIfNull<T>(this Task<T> input)
    {
      if (input == null)
        return Task.FromResult<T>(default);
      return input;
    }

    /// <summary>
    /// Gets an attribute on an enum field value.
    /// </summary>
    /// <typeparam name="T">The type of the attribute to retrieve.</typeparam>
    /// <param name="enumValue">The enum value.</param>
    /// <returns>
    /// The attribute of the specified type or null.
    /// </returns>
    public static T GetAttributeOfType<T>(this Enum enumValue) where T : Attribute
    {
      var type = enumValue.GetType();
      var memInfo = type.GetMember(enumValue.ToString()).First();
      var attributes = memInfo.GetCustomAttributes<T>(false);
      return attributes.FirstOrDefault();
    }
    public static IEnumerable<T> GetAttributesOfType<T>(this Enum enumValue) where T : Attribute
    {
      var type = enumValue.GetType();
      var memInfo = type.GetMember(enumValue.ToString()).First();
      return memInfo.GetCustomAttributes<T>(false);
    }

    public static T[] Shuffle<T>(this IEnumerable<T> enumerable)
    {
      var list = enumerable.ToArray();
      int n = list.Length;

      while (n > 1)
      {
        n--;
        int k = _rng.Next(n + 1);
        T value = list[k];
        list[k] = list[n];
        list[n] = value;
      }

      return list;
    }

    public static IEnumerable<IReadOnlyList<T>> Batch<T>(this T[] array, int batchSize)
    {
      var totalBatches = array.Length / batchSize;

      for (var i = 0; i < totalBatches; i++)
      {
        var start = i * batchSize;
        var end = (i + 1) * batchSize;
        yield return array[start..end];
      }

      var numProcessed = totalBatches * batchSize;

      if (numProcessed != array.Length)
      {
        yield return array[numProcessed..^numProcessed];
      }
    }

    public static async IAsyncEnumerable<(TInput Input, TOutput Output)> BatchProcess<TInput, TOutput>(this IEnumerable<TInput> array, int batchSize, Func<TInput, Task<TOutput>> startWorkCallback, [EnumeratorCancellation] CancellationToken token = default)
    {
      var tasksUnderway = new List<(TInput Input, Task<TOutput> OutputWork)>();
      var tasksToYield = new List<(TInput Input, Task<TOutput> OutputWork)>();

      foreach (var input in array)
      {
        tasksUnderway.Add((input, startWorkCallback(input)));

        if (tasksUnderway.Count != batchSize)
        {
          continue;
        }

        if (tasksToYield.Count > 0)
        {
          var tasks = tasksToYield;
          var outputToYield =
            (await Task.WhenAll(tasks.Select(tuple => tuple.OutputWork))).Select((output, outputIndex) =>
              (Input: tasks[outputIndex].Input, Output: output));

          foreach (var output in outputToYield)
            yield return output;
        }

        var swap = tasksToYield;
        tasksToYield = tasksUnderway;
        tasksUnderway = swap;
        tasksUnderway.Clear();
      }

      if (tasksUnderway.Count > 0)
        tasksToYield.AddRange(tasksUnderway);

      if (tasksToYield.Count > 0)
      {
        var outputToYield =
          (await Task.WhenAll(tasksToYield.Select(tuple => tuple.OutputWork))).Select((output, outputIndex) =>
            (Input: tasksToYield[outputIndex].Input, Output: output)).ToArray();

        tasksToYield.Clear();

        foreach (var output in outputToYield)
          yield return output;
      }
    }

    public static async IAsyncEnumerable<(TInput Input, TOutput Output)> BatchProcess<TInput, TOutput>(this IAsyncEnumerable<TInput> array, int batchSize, Func<TInput, Task<TOutput>> startWorkCallback, [EnumeratorCancellation] CancellationToken token = default)
    {
      var tasksUnderway = new List<(TInput Input, Task<TOutput> OutputWork)>();
      var tasksToYield = new List<(TInput Input, Task<TOutput> OutputWork)>();

      await foreach (var input in array.WithCancellation(token))
      {
        tasksUnderway.Add((input, startWorkCallback(input)));

        if (tasksUnderway.Count != batchSize)
        {
          continue;
        }

        if (tasksToYield.Count > 0)
        {
          var tasks = tasksToYield;
          var outputToYield =
            (await Task.WhenAll(tasks.Select(tuple => tuple.OutputWork))).Select((output, outputIndex) =>
              (Input: tasks[outputIndex].Input, Output: output));

          foreach (var output in outputToYield)
            yield return output;
        }

        var swap = tasksToYield;
        tasksToYield = tasksUnderway;
        tasksUnderway = swap;
        tasksUnderway.Clear();
      }

      if (tasksUnderway.Count > 0)
        tasksToYield.AddRange(tasksUnderway);

      if (tasksToYield.Count > 0)
      {
        var outputToYield =
          (await Task.WhenAll(tasksToYield.Select(tuple => tuple.OutputWork))).Select((output, outputIndex) =>
            (Input: tasksToYield[outputIndex].Input, Output: output)).ToArray();

        tasksToYield.Clear();

        foreach (var output in outputToYield)
          yield return output;
      }
    }

    public static async Task BatchProcess<TInput>(this IAsyncEnumerable<TInput> array, int batchSize, Func<TInput, Task> startWorkCallback, CancellationToken token = default)
    {
      var tasksUnderway = new List<Task>();
      var tasksToYield = new List<Task>();

      await foreach (var input in array.WithCancellation(token))
      {
        tasksUnderway.Add(startWorkCallback(input));

        if (tasksUnderway.Count != batchSize)
          continue;

        if (tasksToYield.Count > 0)
          await Task.WhenAll(tasksToYield);

        var swap = tasksToYield;
        tasksToYield = tasksUnderway;
        tasksUnderway = swap;
        tasksUnderway.Clear();
      }

      if (tasksUnderway.Count > 0)
        tasksToYield.AddRange(tasksUnderway);

      if (tasksToYield.Count > 0)
        await Task.WhenAll(tasksToYield);
    }


    public static async Task BatchProcess<TInput>(this IEnumerable<TInput> array, int batchSize, Func<TInput, Task> startWorkCallback, CancellationToken token = default)
    {
      var tasksUnderway = new List<Task>();
      var tasksToYield = new List<Task>();

      foreach (var input in array)
      {
        tasksUnderway.Add(startWorkCallback(input));

        if (tasksUnderway.Count != batchSize)
          continue;

        if (tasksToYield.Count > 0)
          await Task.WhenAll(tasksToYield);

        var swap = tasksToYield;
        tasksToYield = tasksUnderway;
        tasksUnderway = swap;
        tasksUnderway.Clear();
      }

      if (tasksUnderway.Count > 0)
        tasksToYield.AddRange(tasksUnderway);

      if (tasksToYield.Count > 0)
        await Task.WhenAll(tasksToYield);
    }

#pragma warning disable 1998
    public static async IAsyncEnumerable<TElement> ToAsyncEnumerable<TElement>(this IEnumerable<TElement> from, [EnumeratorCancellation] CancellationToken token = default)
#pragma warning restore 1998
    {
      foreach (var element in from)
      {
        yield return element;
      }
    }

#pragma warning disable 1998
    public static async IAsyncEnumerable<TElement> ToAsyncEnumerable<TElement>(this Task<IEnumerable<TElement>> from, [EnumeratorCancellation] CancellationToken token = default)
#pragma warning restore 1998
    {
      foreach (var element in await from)
      {
        yield return element;
      }
    }

    public static async Task<TElement[]> ToArrayAsync<TElement>(this IAsyncEnumerable<TElement> from)
    {
      var results = new List<TElement>();

      await foreach (var element in from)
      {
        results.Add(element);
      }

      return results.ToArray();
    }

    public static async Task<T[]> ToArrayAsync<T>(this Task<IEnumerable<T>> source)
    {
      return (await source).ToArray();
    }

    public static IEnumerable<TItem> EmptyIfNull<TItem>(this IEnumerable<TItem> from) =>
      from ?? Enumerable.Empty<TItem>();

    public static IEnumerable<TItem> ForEach<TItem>(this IEnumerable<TItem> source, Action<TItem> action)
    {
      foreach (var item in source)
      {
        action(item);
      }

      return source;
    }

    public static Task ForEachAsync<T>(this IEnumerable<T> source, Func<T, Task> body, CancellationToken token = default)
    {
      return ForEachAsync(source, 4, body, token);
    }

    private static Task ForEachAsync<T>(this IEnumerable<T> source, int dop, Func<T, Task> body, CancellationToken token = default)
    {
      return Task.WhenAll(Partitioner
       .Create(source, EnumerablePartitionerOptions.None)
       .GetPartitions(dop)
       .Select(p => ForEachPartition(p, body)));
    }

    private static async Task ForEachPartition<T>(IEnumerator<T> source, Func<T, Task> body)
    {
      while (source.MoveNext())
        await body(source.Current);
    }

    public static IEnumerable<KeyValuePair<TItem, int>> ForEachIndex<TItem>(this IEnumerable<TItem> source)
    {
      var counter = 0;
      foreach (var item in source)
      {
        yield return new KeyValuePair<TItem, int>(item, counter++);
      }
    }

    public static async IAsyncEnumerable<TElement> Where<TElement>(this IAsyncEnumerable<TElement> from, Func<TElement, bool> predicate, [EnumeratorCancellation] CancellationToken token = default)
    {
      await foreach (var input in from.WithCancellation(token))
      {
        if (predicate(input))
          yield return input;
      }
    }

    public static async IAsyncEnumerable<TElement> Where<TElement>(this IAsyncEnumerable<TElement> from, Func<TElement, Task<bool>> predicate, [EnumeratorCancellation] CancellationToken token = default)
    {
      await foreach (var input in from.WithCancellation(token))
      {
        if (await predicate(input))
          yield return input;
      }
    }

    public static async IAsyncEnumerable<TOutput> Select<TInput, TOutput>(this IAsyncEnumerable<TInput> from, Func<TInput, TOutput> projection, [EnumeratorCancellation] CancellationToken token = default)
    {
      await foreach (var input in from.WithCancellation(token))
      {
        yield return projection(input);
      }
    }

    public static async IAsyncEnumerable<TOutput> SelectAsync<TInput, TOutput>(this IAsyncEnumerable<TInput> from, Func<TInput, ValueTask<TOutput>> projection, [EnumeratorCancellation] CancellationToken token = default)
    {
      await foreach (var input in from.WithCancellation(token))
      {
        yield return await projection(input);
      }
    }

    public static async Task<IEnumerable<TOutput>> SelectAsync<TInput, TOutput>(this IEnumerable<TInput> from, Func<TInput, ValueTask<TOutput>> projection)
    {
      var result = new List<TOutput>();

      foreach (var input in from)
      {
        result.Add(await projection(input));
      }

      return result;
    }

    public static async Task<IEnumerable<TOutput>> SelectAsync<TInput, TOutput>(this IEnumerable<TInput> from, Func<TInput, Task<TOutput>> projection)
    {
      var result = new List<TOutput>();

      foreach (var input in from)
      {
        result.Add(await projection(input));
      }

      return result;
    }

    public static async IAsyncEnumerable<TOutput> SelectManyAsync<TInput, TOutput>(this IAsyncEnumerable<TInput> from, Func<TInput, Task<IEnumerable<TOutput>>> projection)
    {
      await foreach (var input in from)
      {
        foreach (var output in await projection(input))
        {
          yield return output;
        }
      }
    }

    public static async IAsyncEnumerable<TOutput> SelectManyAsync<TInput, TOutput>(this Task<IEnumerable<TInput>> from, Func<TInput, Task<IEnumerable<TOutput>>> projection)
    {
      foreach (var input in await from)
      {
        foreach (var output in await projection(input))
        {
          yield return output;
        }
      }
    }

    public static async Task<bool> Any<T>(this IAsyncEnumerable<T> source, Func<T, bool> predicate)
    {
      await foreach (var item in source)
      {
        if (predicate(item))
        {
          return true;
        }
      }
      return false;
    }

    public static async Task<int> Count<T>(this IAsyncEnumerable<T> source)
    {
      var array = await source.ToArrayAsync();
      return array.Length;
    }

    public static IEnumerable<TValue> Distinct<TValue, TKey>(this IEnumerable<TValue> from, Func<TValue, TKey> keySelector)
    {
      var distinctSet = new HashSet<TKey>();

      foreach (var input in from)
      {
        if (distinctSet.Add(keySelector(input)))
          yield return input;
      }
    }

    public static async Task<TInput> FirstOrDefault<TInput>(this IAsyncEnumerable<TInput> from, Func<TInput, bool> predicate, CancellationToken token = default)
    {
      await foreach (var input in from.WithCancellation(token))
      {
        if (predicate(input))
          return input;
      }

      return default;
    }

    public static async Task<TInput> FirstOrDefaultAsync<TInput>(this IEnumerable<TInput> from, Func<TInput, Task<bool>> predicate)
    {
      foreach (var input in from)
      {
        if (await predicate(input))
          return input;
      }

      return default;
    }

    public static async Task<TInput> FirstOrDefaultAsync<TInput>(this Task<IEnumerable<TInput>> from, Func<TInput, bool> predicate)
    {
      foreach (var input in await from)
      {
        if (predicate(input))
          return input;
      }

      return default;
    }

    public static async IAsyncEnumerable<TInput> WhereAsync<TInput>(this IEnumerable<TInput> from, Func<TInput, Task<bool>> filter)
    {
      foreach (var input in from)
      {
        if (await filter(input))
        {
          yield return input;
        }
      }
    }

    public static async Task<IEnumerable<TInput>> WhereAsync<TInput>(this Task<IEnumerable<TInput>> from, Func<TInput, Task<bool>> filter)
    {
      var result = new List<TInput>();
      foreach (var input in await from)
      {
        if (await filter(input))
        {
          result.Add(input);
        }
      }

      return result;
    }

    public static async Task<IEnumerable<TInput>> WhereAsync<TInput>(this Task<IEnumerable<TInput>> from, Func<TInput, bool> filter)
    {
      var result = new List<TInput>();
      foreach (var input in await from)
      {
        if (filter(input))
        {
          result.Add(input);
        }
      }

      return result;
    }

    public static async Task<bool> AllAsync<TInput>(this IEnumerable<TInput> from, Func<TInput, Task<bool>> predicate)
    {
      foreach (var input in from)
      {
        if (!await predicate(input))
        {
          return false;
        }
      }
      return true;
    }

    public static IEnumerable<TItem> AsEnumerable<TItem>(this TItem from) =>
      new OneEnumerable<TItem>(from);

    private struct OneEnumerable<TItem> : IEnumerable<TItem>
    {
      private readonly TItem _item;

      public OneEnumerable(TItem item)
      {
        _item = item;
      }

      public IEnumerator<TItem> GetEnumerator()
      {
        return new OneEnumerator<TItem>(_item);
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return GetEnumerator();
      }
    }

    private struct OneEnumerator<TItem> : IEnumerator<TItem>
    {
      private readonly TItem _item;
      private TItem _current;
      private bool _assigned;

      public OneEnumerator(TItem item)
      {
        _item = item;
        _current = default;
        _assigned = false;
      }

      public bool MoveNext()
      {
        if (!_assigned)
        {
          _assigned = true;
          _current = _item;
          return true;
        }

        _current = default;
        return false;
      }

      public void Reset()
      {
        _current = default;
        _assigned = false;
      }

      public TItem Current
      {
        get
        {
          if (_current == null)
            throw new InvalidOperationException("Please call MoveNext prior to accessing Current");
          return _current;
        }
      }

      object IEnumerator.Current => Current;

      public void Dispose() { }
    }
  }
}
