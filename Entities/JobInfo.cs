namespace employer_jobs_api.Entities
{
    public class JobInfo
    {
        public long JobId { get; set; }
        public string? JobPositionId { get; set; }
        public long UserId { get; set; }
        public long CustomerId { get; set; }
        public string? JobTitle { get; set; }
        
        public Nullable<int> NumberOfVacancies { get; set; }
     
        public Nullable<int> ClientId { get; set; }
      
        public Nullable<bool> IsActive { get; set; }
       
        public Nullable<bool> IsDrafted { get; set; }
        public System.DateTime PostedDate { get; set; }
        public long PostedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
       
        public Nullable<System.DateTime> ExpiryDate { get; set; }
      
     
        public string? JobPriority { get; set; }

        public JobStats? Jstat { get; set; }


    }
}
