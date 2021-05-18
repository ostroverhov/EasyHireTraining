using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using SpecFlowEasyHire.Models;

namespace SpecFlowEasyHire.Utils
{
    public class DataBaseUtils
    {
        private static readonly string ConnectionString =
            @"datasource=localhost;port=3308;username=root;password=test;database=TestData";
        private static readonly string GetTestUsersRrequest = "SELECT * FROM TestUsers";

        public static SignUpUser GetFirstTestUser()
        {
            SignUpUser testUser;
            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                testUser = connection.Query<SignUpUser>(GetTestUsersRrequest).First();
                connection.Close();
            }
            return testUser;
        }
    }
}