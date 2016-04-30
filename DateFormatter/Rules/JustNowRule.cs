using System;

namespace FormatHelper.Rules
{
  public class JustNowRule: DateRule, IDateRule
  {
    public JustNowRule(string stringToReturn) : base(stringToReturn)
    {
    }

    public bool ShouldApply(TimeSpan timeSpan)
    {
      return timeSpan.Seconds <= 59 && timeSpan.Minutes == 0 && timeSpan.Hours == 0 && timeSpan.Days == 0;
    }

    public string GetStringValue()
    {
      return StringToReturn;
    }
  }
}
