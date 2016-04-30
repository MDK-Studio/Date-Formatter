using System;

namespace FormatHelper.Rules
{
  public class MinutesAgoRule :DateRule, IDateRule
  {

    public MinutesAgoRule(string stringToReturn) : base(stringToReturn)
    {
    }

    public bool ShouldApply(TimeSpan timeSpan)
    {
      return timeSpan.Minutes >= 1 && timeSpan.Minutes <= 5 && timeSpan.Hours == 0;
    }

    public string GetStringValue()
    {
      return StringToReturn;
    }
  }
}
