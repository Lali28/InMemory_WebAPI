namespace ProjectManagementAPI.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Client { get; set; }
        public decimal CostSavingsPerMonth { get; set; }
        public decimal TimeSavingsPerMonth { get; set; }

        
    }
}
