using System;

namespace MyDateOfBirth
{
  public class GetDateOfBirth
  {
    private readonly IExtractDateOfBirth _extractDateOfBirth;

    public GetDateOfBirth(IExtractDateOfBirth extractDateOfBirth)
    {
      _extractDateOfBirth = extractDateOfBirth;
    }

    public DateTime? GetDateOfBirthFromIdNumber(string identityNumber)
    {
      var dateOfBirth = _extractDateOfBirth.GetDateOfBirth(identityNumber);
      return dateOfBirth;
    }
  }
}
