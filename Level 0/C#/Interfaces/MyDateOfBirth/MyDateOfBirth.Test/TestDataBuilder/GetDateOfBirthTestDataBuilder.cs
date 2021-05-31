using System;
using NSubstitute;

namespace MyDateOfBirth.Test.TestDataBuilder
{
  public class GetDateOfBirthTestDataBuilder
  {
    private readonly IExtractDateOfBirth _extractDateOfBirth;

    public GetDateOfBirthTestDataBuilder()
    {
      _extractDateOfBirth = Substitute.For<IExtractDateOfBirth>();
    }

    public GetDateOfBirth Build()
    {
      return new GetDateOfBirth(_extractDateOfBirth);
    }

    public GetDateOfBirthTestDataBuilder WithDateOfBirthReturning(string identityNumber, DateTime? dateOfBirth)
    {
      _extractDateOfBirth.GetDateOfBirth(identityNumber).Returns(dateOfBirth);
      return this;
    }
  }
}
