using System;

namespace FormatHelper
{
  public interface IDateFormatter
  {
    string GetLastActive(DateTime pastDate, DateTime presentDate);
  }
}
