using System;

namespace FormatHelper.Rules
{
  public class LessThanHourAgoRule :DateRule, IDateRule
  {

    public LessThanHourAgoRule(string stringToReturn) : base(stringToReturn)
    {
    }

    public bool ShouldApply(TimeSpan timeSpan)
    {
      return timeSpan.Minutes >= 5 && timeSpan.Minutes <= 30 && timeSpan.Hours == 0;
    }

    public string GetStringValue()
    {
      return StringToReturn;
    }
  }
}
