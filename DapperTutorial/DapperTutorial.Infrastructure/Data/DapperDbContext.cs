using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Infrastructure.Data
{
    public class DapperDbContext
    {
        IDbConnection dbConnection;
        public DapperDbContext() {
           // dbConnection = new SqlConnection("");
            //string conn = new ConfigurationBuilder().AddJsonFile("appSetting.json").Build().GetConnectionString("JuneBatch");
            //  SqlConnection secondWay = new SqlConnection (conn);
        }
        public IDbConnection GetConnection()
        {
            SqlConnection dbConnection = new SqlConnection("Data Source=.;Initial Catalog=JuneBatch;Integrated Security=True");
            return dbConnection; // return conn
        }
    }
}
