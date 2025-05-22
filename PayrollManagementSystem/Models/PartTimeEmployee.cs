namespace PayrollManagementSystem.Models
{
    public class PartTimeEmployee : BaseEmployee
    {
        public decimal HourlyRate { get; set; }
        public int TotalHoursWorked { get; set; }
        public int MaxAllowedHours = 25; // Example threshold

        public override decimal CalculateSalary()
        {
            if (TotalHoursWorked > MaxAllowedHours)
                Console.WriteLine("Warning: Overtime hours!");

            return HourlyRate * TotalHoursWorked;
        }
    }
}
