using System;
using System.Collections.Generic;
using FormatHelper.Rules;

namespace FormatHelper
{
  public class DateFormatter : IDateFormatter
  {
    private List<IDateRule> _dateRules; 
    public DateFormatter()
    {
      _dateRules = new List<IDateRule>()
      {
        new MinutesAgoRule("Minutes ago"),
        new LessThanHourAgoRule("Less than hour ago"),
        new HoursAgoRule(string.Empty),
        new DaysAgoRule(string.Empty),
        new JustNowRule("Just now")
      };
    }

    public string GetLastSeenFormat(DateTime pastDate, DateTime presentDate)
    {
      var timespanDifference = presentDate.Subtract(pastDate);

      foreach (var dateRule in _dateRules)
      {
        if (dateRule.ShouldApply(timespanDifference))
        {
          return dateRule.GetStringValue();
        }
      }

      return "";
    }
  }
}
