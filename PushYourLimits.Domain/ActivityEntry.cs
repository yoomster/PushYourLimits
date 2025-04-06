using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PushYourLimits.Domain
{
    public class ActivityEntry
    {
        private ActivityEntry()
        {
            
        }
        public ActivityEntry(
            ActivityType activityType,
            int userId,
            DateOnly date,
            TimeOnly startTime,
            TimeOnly endTime
            )
        {
            if (activityType == null)
            {
                throw new ArgumentException(nameof(activityType));
            }

            if (date > DateOnly.FromDateTime(DateTime.Now))
                throw new ArgumentException("Datum kan niet in de toekomst liggen.");

            if (endTime <= startTime)
                throw new ArgumentException("Eindtijd moet later zijn dan starttijd.");

            ActivityType = activityType;
            UserId = userId;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
        }

        public int Id { get; init; }
        public int UserId { get; init; }
        public ActivityType ActivityType { get; init; } 
        public DateOnly Date { get; init; }
        public TimeOnly StartTime { get; init; }
        public TimeOnly EndTime { get; init; }
        public int DurationInMinutes => (int)(EndTime - StartTime).TotalMinutes;
    }
}
