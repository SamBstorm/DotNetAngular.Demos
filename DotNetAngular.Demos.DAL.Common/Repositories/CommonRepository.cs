using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DotNetAngular.Demos.DAL.Common.Repositories
{
    public abstract class CommonRepository
    {
        protected IConfiguration _configuration;
        private string _dbName;
        protected string _connectionString => _configuration.GetConnectionString(_dbName);
        protected DbProviderFactory _factory => DbProviderFactories.GetFactory("System.Data.SqlClient");

        //private string _connectionString => _configuration.GetValue<string>($"Modules:{_dbName}:ConnectionString");
        //private DbProviderFactory _factory => DbProviderFactories.GetFactory(_configuration.GetValue<string>($"Modules:{_dbName}:InvariantName"));
        public CommonRepository(IConfiguration config, string dbName)
        {
            _configuration = config;
            _dbName = dbName;
        }
    }
}
