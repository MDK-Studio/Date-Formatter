using System;
using FormatHelper.Extensions;

namespace FormatHelper.Rules
{
  public class HoursAgoRule :DateRule, IDateRule
  {
    private TimeSpan _timeSpan;

    public HoursAgoRule(string stringToReturn) : base(stringToReturn)
    {
    }

    public bool ShouldApply(TimeSpan timeSpan)
    {
      _timeSpan = timeSpan;
      return timeSpan.Hours >= 1 && timeSpan.Days == 0;
    }

    public string GetStringValue()
    {
      var hourString = "Hour".PluralizeDateString(_timeSpan.Hours);
      return $"{_timeSpan.Hours} {hourString} ago";
    }
  }
}
