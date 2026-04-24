using Dapper;
using Microsoft.Data.SqlClient;
using SalesManahmentSystemBLL.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Text;

namespace SalesManahmentSystemDAL
{
    public class DataBaseHelper
    {
        IDbConnection connection;
        private static DataBaseHelper? _instance;
        private static readonly object _lock = new object();
        private DataBaseHelper()
        {
            if (connection == null)
            {
                connection = new SqlConnection
                (@"Server=.; Database =SSTOREONLINE; USER ID=sa ; PASSWORD = 123456;
Trusted_Connection=True; TrustServerCertificate = True;");
            }
        }
        public static DataBaseHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DataBaseHelper();
                        }
                    }
                }
                return _instance;
            }
        }
        public  async Task<IEnumerable<T>> ExecuteSelect<T>(string query, 
            object? parameters =null)
        {
            return await connection.QueryAsync<T>(query, parameters);
            
        }
        public  async Task<T?> QuerySingleOrDefualt<T>(string query, object? parameters = null)
        {
            return await connection.QuerySingleOrDefaultAsync<T>(query, parameters);
        }

        public  async Task<int> ExecuteDML(string command, object? paramter = null)
        {
            int affectedRows = await connection.ExecuteAsync(command, paramter);
            return affectedRows;
        }
        public  async Task<bool> ExecuteTransaction(List<string> commands)
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
                            await connection.ExecuteAsync(command, transaction: transaction);
                        }
                        transaction.Commit();
                        isSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        ex.LogEvent();
                        transaction.Rollback();
                        // Handle exceptions (e.g., log the error)
                        return isSuccess;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.LogEvent();
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
