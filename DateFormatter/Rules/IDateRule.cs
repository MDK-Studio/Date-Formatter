using System;

namespace FormatHelper.Rules
{
  public interface IDateRule
  {
    bool ShouldApply(TimeSpan timeSpan);
    string GetStringValue();
  }
}
