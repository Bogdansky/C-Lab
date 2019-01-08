public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        string sec = seconds % 60 > 9 ? (seconds % 60).ToString() : "0" + seconds % 60;
        seconds /= 60;
        string min = seconds % 60 > 9 ? (seconds % 60).ToString() : "0" + seconds % 60;
        seconds /= 60;
        string hour = seconds > 9 ? seconds.ToString() :"0" + seconds;
        return hour + ":"+ min + ":" + sec;
    }
}
