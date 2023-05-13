using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataBaseIntegration
{
    public class DataBaseAccess
    {
        //Leitura do arquivo de configurações
        private static string dbHost = ConfigurationManager.AppSettings["dbHost"];
        private static string dbPort = ConfigurationManager.AppSettings["dbPort"];
        private static string dbName = ConfigurationManager.AppSettings["dbName"];
        private static string dbUser = ConfigurationManager.AppSettings["dbUser"];
        private static string dbPass = ConfigurationManager.AppSettings["dbPass"];

        //Método de conexão com o banco

        public NpgsqlConnection OpenConnection()
        {
            string connectionString = String.Format(
                "Server = {0}; User Id = {1}; Database = {2}; Port = {3}; Password = {4};",
                dbHost, dbUser, dbName, dbPort, dbPass);

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            return connection;
        } 
    }
}
