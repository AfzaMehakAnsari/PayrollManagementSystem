namespace PayrollManagementSystem.Models
{
    public class Freelancer : BaseEmployee
    {
        public int TasksCompleted { get; set; }
        public decimal RatePerTask { get; set; }

        public override decimal CalculateSalary()
        {
            return TasksCompleted * RatePerTask;
        }
    }
}
