using System.Text.RegularExpressions;

namespace HackerRank.Week1;

public class TimeConversion
{
    public string Convert(string time)
    {
        const string pattern = @"^(\d{1,2}):(\d{2}):(\d{2})([APMapm]{2})$";
        var match = Regex.Match(time, pattern);
        int hours = int.Parse(match.Groups[1].Value);
        int minutes = int.Parse(match.Groups[2].Value);
        int seconds = int.Parse(match.Groups[3].Value);
        string amPm = match.Groups[4].Value.ToUpper();

        if (amPm == "PM")
        {
            if (hours < 12)
            {
                hours += 12;
            }
        }
        else
        {
            if (hours > 11)
            {
                hours = 0;
            }
        }

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }
}
