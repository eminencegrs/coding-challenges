using System.Text.RegularExpressions;

namespace HackerRank.Week1;

public static class TimeConversion
{
    public static string Convert(string time)
    {
        const string pattern = @"^(\d{1,2}):(\d{2}):(\d{2})([APMapm]{2})$";
        var match = Regex.Match(time, pattern, RegexOptions.Compiled);
        if (!match.Success)
        {
            throw new ArgumentException("Invalid time format.");
        }

        var hours = int.Parse(match.Groups[1].Value);
        var minutes = int.Parse(match.Groups[2].Value);
        var seconds = int.Parse(match.Groups[3].Value);
        var amPm = match.Groups[4].Value.ToUpper();

        if (hours < 1 || hours > 12 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
        {
            throw new ArgumentException("Invalid time value.");
        }

        if (amPm == "PM" && hours != 12)
        {
            hours += 12;
        }
        else if (amPm == "AM" && hours == 12)
        {
            hours = 0;
        }

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }
}
