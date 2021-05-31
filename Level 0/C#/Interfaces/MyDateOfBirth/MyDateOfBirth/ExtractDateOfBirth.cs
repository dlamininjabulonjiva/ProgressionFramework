using System;
using System.Globalization;

namespace MyDateOfBirth
{
  public class ExtractDateOfBirth : IExtractDateOfBirth
  {
    public DateTime? GetDateOfBirth(string identityNumber)
    {
      if (DateTime.TryParseExact(identityNumber.Substring(0, 6)
        , "yyMMdd"
        , CultureInfo.InvariantCulture
        , DateTimeStyles.None
        , out var date))
      {
        return DateTime.SpecifyKind(date, DateTimeKind.Utc);
      }

      return null;
    }
  }
}
