namespace vams_onair_api.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public Guid WorldId { get; set; }
        public string Name { get; set; }
        public string AirlineCode { get; set; }
        public DateTime LastConnection { get; set; }
        public DateTime LastReportDate { get; set; }
        public decimal Reputation { get; set; }
        public DateTime CreationDate { get; set; }
        public int DifficultyLevel { get; set; }
        public decimal UTCOffsetinHours { get; set; }
        public bool Paused { get; set; }
        public int Level { get; set; }
        public int LevelXP { get; set; }
        public bool TransportEmployeeInstant { get; set; }
        public bool TransportPlayerInstant { get; set; }
        public bool ForceTimeInSimulator { get; set; }
        public bool UseSmallAirports { get; set; }
        public bool UseOnlyVanillaAirports { get; set; }
        public bool EnableSkillTree { get; set; }
        public int CheckrideLevel { get; set; }
        public bool EnableLandingPenalities { get; set; }
        public bool EnableEmployeesFlightDutyAndSleep { get; set; }
        public int AircraftRentLevel { get; set; }
        public bool EnableCargosAndChartersLoadingTime { get; set; }
        public bool InSurvival { get; set; }
        public decimal PayBonusFactor { get; set; }
        public bool EnableSimFailures { get; set; }
        public bool DisableSeatsConfigCheck { get; set; }
        public bool RealisticSimProcedures { get; set; }
        public int TravelTokens { get; set; }
        public int SkillTreeResetCount { get; set; }
        public int IndustryPoints { get; set; }
        public int TotalIndustryPoints { get; set; }
        public int TotalContractsCompleted { get; set; }
        public decimal TotalContractsEarnedCredits { get; set; }
        public int CompanyType { get; set; }
    }
}
