using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PushYourLimits.Domain
{
    public class SportPerformance
    {
        public SportPerformance(
            SportType sportType, 
            float distance, 
            int durationInMinutes, 
            DateOnly date)
        {
            if (distance < 0)
                throw new ArgumentException("Afstand kan niet negatief zijn.");

            if (durationInMinutes <= 0)
                throw new ArgumentException("Duur moet groter dan 0 minuten zijn.");

            if (date > DateOnly.FromDateTime(DateTime.Now))
                throw new ArgumentException("Datum kan niet in de toekomst liggen.");

            SportType = sportType;
            Distance = distance;
            DurationInMinutes = durationInMinutes;
            Date = date;
        }

        public int Id { get; init; }
        public SportType SportType { get; init; }
        public float Distance { get; init; }
        public int DurationInMinutes { get; init; }
        public DateOnly Date { get; init; }
    }
}
