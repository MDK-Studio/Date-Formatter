namespace FormatHelper.Extensions
{
  public static class AppExtensions
  {
    public static string PluralizeDateString(this string singularDateFormat, int value)
    {
      var finalDateFormat = "";
      if (value == 1)
        finalDateFormat = $"{singularDateFormat}";
      else
        finalDateFormat = $"{singularDateFormat}s";

      return finalDateFormat;
    }

  }
}
