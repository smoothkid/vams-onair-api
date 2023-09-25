namespace vams_onair_api.Models
{
    public class AircraftType
    {
        public Guid Id { get; set; }
        public string Hash { get; set; }
        public Guid AircraftClassId { get; set; }
        public AircraftClass AircraftClass { get; set; } = new AircraftClass();
        public DateTime CreationDate { get; set; }
        public DateTime LastModerationDate { get; set; }
        public string DisplayName { get; set; }
        public string TypeName { get; set; }
        public long FlightsCount { get; set; }
        public int TimeBetweenOverhaul { get; set; }
        public long HightimeAirframe { get; set; }
    }
}
