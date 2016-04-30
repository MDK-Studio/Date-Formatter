using System;
using FormatHelper.Extensions;

namespace FormatHelper.Rules
{
  public class DaysAgoRule : DateRule, IDateRule
  {
    private TimeSpan _timeSpan;

    public DaysAgoRule(string stringToReturn) : base(stringToReturn)
    {
    }

    public bool ShouldApply(TimeSpan timeSpan)
    {
      _timeSpan = timeSpan;
      return timeSpan.Days >= 1;
    }

    public string GetStringValue()
    {
      var dayString = "Day".PluralizeDateString(_timeSpan.Days);
      return $"{_timeSpan.Days} {dayString} ago";
    }
  }
}
