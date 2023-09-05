using Application.Repositories;
using Dapper;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            var query = $"SELECT * FROM User WHERE Email = @email ";

            var parameters = new DynamicParameters();
            parameters.Add("Email", email, DbType.String);

            using (SqlConnection conn = new(_connectionString))
            {
                conn.Open();
                var data = await conn.QueryFirstOrDefaultAsync<User>(query, parameters);
                return data;
            }
        }
    }
}
