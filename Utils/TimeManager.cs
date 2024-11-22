namespace BA.Utils
{
    public static class TimeManager
    {
        public static readonly TimeZoneInfo TimeZone = TimeZoneInfo.FindSystemTimeZoneById(
            "Korea Standard Time"
        );
        public static DateTimeOffset Now
        {
            get
            {
                var now = DateTimeOffset.Now;
                return TimeZoneInfo.ConvertTime(now, TimeZone);
            }
        }

        public static DateTime KoreaNow
        {
            get
            {
                var now = DateTime.Now;
                return TimeZoneInfo.ConvertTime(now, TimeZone);
            }
        }

        public static DateTimeOffset Parse(string timestamp)
        {
            var parsedDateTime = DateTime.Parse(timestamp);
            DateTimeOffset dateTimeOffset =
                new(parsedDateTime, TimeZone.GetUtcOffset(parsedDateTime));
            return TimeZoneInfo.ConvertTime(dateTimeOffset, TimeZone);
        }
    }
}
