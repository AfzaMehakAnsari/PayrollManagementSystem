namespace PayrollManagementSystem.Models
{
    public class FullTimeEmployee : BaseEmployee
    {
        public decimal AnnualSalary { get; set; }
        public int WorkingHoursPerWeek { get; set; }
        public int WorkingWeeksPerYear { get; set; }
        public int LoggedHours { get; set; }

        public override decimal CalculateSalary()
        {
            if (WorkingHoursPerWeek == 0 || WorkingWeeksPerYear == 0)
                throw new Exception("Invalid working hours configuration.");

            decimal hourlyRate = AnnualSalary / (WorkingHoursPerWeek * WorkingWeeksPerYear);
            return hourlyRate * LoggedHours;
        }
    }
}
