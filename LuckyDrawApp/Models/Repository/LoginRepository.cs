using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace LuckyDrawApp.Models.Repository
{
    public class LoginRepository
    {
        public static AccountModel Login(string UserName, string Password, string Server)
        {
           
            AccountModel result = new AccountModel();
            try
            {
                string sql = "select * from LuckyDrawLogin where  UserName='" + UserName + "' and Password = '"+Password+"'";
                using (var conn = new SqlConnection(Server))
                {
                    result = (AccountModel)conn.QueryFirst<AccountModel>(sql, null, commandType: System.Data.CommandType.Text, commandTimeout: 30);
                    conn.Dispose();
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
