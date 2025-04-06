namespace PushYourLimits.Domain
{
    public class ActivityType
    {
        public ActivityType(int id, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) 
                throw new ArgumentException("Naam van de activiteit is nog niet gevuld.");

            Id = id;
            Name = name;
        }

        public int Id { get; init; }
        public string Name { get; init; }
    }
}