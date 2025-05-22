namespace PayrollManagementSystem.Models
{
    public class ContractEmployee : BaseEmployee
    {
        public bool IsMilestoneBased { get; set; }
        public decimal FeePerMilestone { get; set; }
        public int MilestonesCompleted { get; set; }
        public decimal FixedProjectFee { get; set; }

        public override decimal CalculateSalary()
        {
            return IsMilestoneBased ? FeePerMilestone * MilestonesCompleted : FixedProjectFee;
        }
    }
}
