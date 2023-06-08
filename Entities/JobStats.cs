namespace employer_jobs_api.Entities
{
    public class JobStats
    {

        public long JobId { get; set; }

        public long? AllCandidates { get; set; }

        public long? Applied { get; set; }

        public long? ShortListed { get; set; }

       public long? Screening { get; set; }

       public long? Interviewed { get; set; }

       public long? Hired { get; set; }

       public long? RejectedORWithdrawn { get; set; }

       public long? InProgress { get; set; }
    }
}
