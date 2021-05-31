using System;

namespace MyDateOfBirth
{
  public interface IExtractDateOfBirth
  {
    DateTime? GetDateOfBirth(string identityNumber);
  }
}
