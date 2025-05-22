namespace PayrollManagementSystem.Models
{
    public abstract class BaseEmployee
    {
        public string Name { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public abstract decimal CalculateSalary();
    }
}
