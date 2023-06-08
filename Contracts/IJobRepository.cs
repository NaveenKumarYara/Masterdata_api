namespace masterdata_api.Contracts
{
    public interface IJobRepository
    {
       public Task<IEnumerable<dynamic>> GetJobTitles(string jobtitle);
    }
}
