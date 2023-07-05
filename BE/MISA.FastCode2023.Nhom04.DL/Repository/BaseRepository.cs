using Microsoft.Extensions.Configuration;
using MISA.FastCode2023.Nhom04.DL.Interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.FastCode2023.Nhom04.DL.Repository
{
    public abstract class BaseRepository<TEntity, TEntityFilter> : IBaseRepository<TEntity, TEntityFilter>
    {
        protected readonly string _connectionString;
        protected string table;

        public BaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionString"];
            table = typeof(TEntity).Name;
        }

        public virtual async Task<DbConnection> GetOpenConnectionAsync()
        {
            var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }
    }
}
