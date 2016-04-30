using System;

namespace FormatHelper
{
  public interface IDateFormatter
  {
    string GetLastSeenFormat(DateTime pastDate, DateTime presentDate);
  }
}
