using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    public class DBHelper
    {
        // Connection
        private OleDbConnection conn;
        private string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\yahoo19\documents\visual studio 2010\Projects\CoachingManagementSystem\CoachingManagementSystem\CoachingManagementSystem1.accdb;User Id=admin;Password=;";

        public string ConString
        {
            get { return conString; }
            set { conString = value; }
        }

        public DBHelper()
        {
            conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = conString;
            conn.Open();
        }

        public int ExecuteNonQuery(string query)
        {
            OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, conn);
            return cmd.ExecuteNonQuery();
        }

        public void close()
        {
            conn.Close();
        }

        public OleDbDataReader ExecuteQuery(string query)
        {
            OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, conn);
            return cmd.ExecuteReader();
        }
    }
}
