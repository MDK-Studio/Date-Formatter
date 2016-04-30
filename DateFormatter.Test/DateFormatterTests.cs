using System;
using NUnit.Framework;

namespace FormatHelper.Test
{
  [TestFixture]
  public class DateFormatterTests
  {
    [Test]
    public void GetLastSeen_GivenDateWithFewMinutesDifference_ShouldReturnMinutesAgo()
    {
      var formatter = GetDateFormatter();
      var pastDate = DateTime.Now;
      var presentDate = GetPresentDateTime(minutes: 5);

      var result = formatter.GetLastActive(pastDate, presentDate);

      Assert.AreEqual("Minutes ago", result, "When time is less than 5 minutes difference you should see minutes ago");
    }

    [Test]
    public void GetLastSeen_GivenDateWith30MinutesDifference_ShouldReturnLessThanHourAgo()
    {
      var formatter = GetDateFormatter();
      var pastDate = DateTime.Now;
      var presentDate = GetPresentDateTime(minutes: 30);

      var result = formatter.GetLastActive(pastDate, presentDate);

      Assert.AreEqual("Less than hour ago", result, "When time is less than 30 minutes difference you should see Hour ago");
    }

    [TestCase(1, "1 Hour ago")]
    [TestCase(6, "6 Hours ago")]
    [TestCase(13, "13 Hours ago")]
    [TestCase(23, "23 Hours ago")]
    public void GetLastSeen_GivenDateWithHoursDifference_ShouldReturnHoursHourAgo(int hours, string expectedFormat)
    {
      var formatter = GetDateFormatter();
      var pastDate = DateTime.Now;
      var presentDate = GetPresentDateTime(hours: hours);

      var result = formatter.GetLastActive(pastDate, presentDate);

      Assert.AreEqual(expectedFormat, result, $"Expected time of {hours} hours difference to say {expectedFormat}");
    }

    [TestCase(1, "1 Day ago")]
    [TestCase(3, "3 Days ago")]
    public void GetLastSeen_GivenDateWithDaysDifference_ShouldReturnDaysHourAgo(int days, string expectedFormat)
    {
      var formatter = GetDateFormatter();
      var pastDate = DateTime.Now;
      var presentDate = GetPresentDateTime(days: days);

      var result = formatter.GetLastActive(pastDate, presentDate);

      Assert.AreEqual(expectedFormat, result, $"Expected time of {days} days difference to say {expectedFormat}");
    }

    [Test]
    public void GetLastSeen_GivenDateWithLessThanAMinuteDifference_ShouldReturnJustNow()
    {
      var formatter = GetDateFormatter();
      var pastDate = DateTime.Now;
      var presentDate = GetPresentDateTime();

      var result = formatter.GetLastActive(pastDate, presentDate);

      Assert.AreEqual("Just now", result, "When time is less than a minute, should say Just now");
    }

    private static DateTime GetPresentDateTime(int months = 0, int days = 0, int hours = 0, int minutes = 0, int seconds = 0)
    {
      var presentDate = DateTime.Now
      .AddMonths(months)
      .AddDays(days)
      .AddHours(hours)
      .AddMinutes(minutes)
      .AddSeconds(seconds);

      return presentDate;
    }

    private static DateFormatter GetDateFormatter()
    {
      return new DateFormatter();
    }
  }
}
