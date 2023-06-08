using Dapper;
using employer_jobs_api.Context;
using masterdata_api.Contracts;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace employer_jobs_api.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly DapperContext _context;
        private string? customerjobquery;
        private string? jobStatsquery;
        public JobRepository(DapperContext context)
        {
            _context = context;
        }





        public async Task<IEnumerable<dynamic>> GetJobTitles(string jobtitle)
        {
            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<dynamic>("Usp_Search_JobTitle", new { jobtitle }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }


    }
}
