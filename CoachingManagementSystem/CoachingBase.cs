using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    public class CoachingBase
    {

        #region query
        virtual public string buildStringForQuery() 
        {
          throw new MissingMethodException();
        }

        virtual public object convertFromReader(OleDbDataReader dr) 
        {
            throw new MissingMethodException();        
        }
        
        public List<object> get()
        {
            List<object> retColl = new List<object>();

            // Create DBHelper's Instance
            DBHelper dbhelper = new DBHelper();
            // Get query string
            string insertstr = buildStringForQuery();
            // Get from DB
            OleDbDataReader dr = dbhelper.ExecuteQuery(insertstr);
            // Get rows and convert them to user collection
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    retColl.Add(convertFromReader(dr));
                }
            }
            // Close DB Helper
            dbhelper.close();
            return retColl;

        }

        protected string getQueryPartialString(string FieldName, string FieldValue)
        {
            return " " + FieldName + " = '" + FieldValue + "' and";
        }

        protected string getQueryPartialString(string FieldName, int FieldValue)
        {
            return " " + FieldName + " = '" + FieldValue + "' and";
        }

        protected string getFinalQueryString(string queryStr, string tableName)
        {
            // Delete trailing "and"
            if (queryStr.EndsWith("and"))
            {
                queryStr = queryStr.Remove(queryStr.Length - 3);
            }
            queryStr = "Select * from [" + tableName + "] where " + queryStr;

            return queryStr;

        }
        #endregion Query

        #region insert
        virtual public string buildStringForInsert()
        {
            throw new MissingMethodException();
        }

        /* Public Methods */
        public void save()
        {
            // Create DBHelper's Instance
            DBHelper dbhelper = new DBHelper();
            // Get insert string
            string insertstr = buildStringForInsert();
            // Insert into DB
            dbhelper.ExecuteNonQuery(insertstr);
            // Close DB Helper
            dbhelper.close();

        }

        protected string getInsertStringField(string fieldName)
        {
            return ",[" + fieldName + "]";
        }

        protected string getInsertStringFieldValue(string fieldValue)
        {
            return ",'" + fieldValue + "'";
        }

        protected string getInsertStringFieldValue(int fieldValue)
        {
            return "," + fieldValue + "";
        }

        protected string getFinalInsertString(string TableName, string FieldNames, string FieldValues)
        {
            FieldNames = FieldNames.Trim(',');
            FieldValues = FieldValues.Trim(',');
            return "Insert Into [" + TableName + "] (" + FieldNames + ") Values (" + FieldValues + ")";
        }
        #endregion
    }
}
