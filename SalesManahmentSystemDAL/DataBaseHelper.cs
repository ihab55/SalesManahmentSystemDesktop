using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SalesManahmentSystemDAL
{
    public static class DataBaseHelper
    {
        static IDbConnection connection;
        static DataBaseHelper()
        {
            if (connection == null)
            {
                connection = new SqlConnection
                (@"Server=.; Database =SSTOREONLINE; USER ID=sa ; PASSWORD = 123456;
Trusted_Connection=True; TrustServerCertificate = True;");
            }
        }
        public static IEnumerable<T> ExecuteSelect<T>(string query, 
            object? parameters =null)
        {
            return connection.Query<T>(query, parameters);
            
        }
        public static T? QuerySingleOrDefualt<T>(string query, object? parameters = null)
        {
            return connection.QuerySingleOrDefault<T>(query, parameters);
        }

        public static int ExecuteDML(string command, object? paramter = null)
        {
            int affectedRows = connection.Execute(command, paramter);
            return affectedRows;
        }
        public static bool ExecuteTransaction(List<string> commands)
        {
            bool isSuccess = false;
            try
            {
                connection.Open();
                using(IDbTransaction transaction = connection.BeginTransaction()){
                    try
                    {
                        foreach (string command in commands)
                        {
                            connection.Execute(command, transaction: transaction);
                        }
                        transaction.Commit();
                        isSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        // Handle exceptions (e.g., log the error)
                        return isSuccess;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
    }
}
