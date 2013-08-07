using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class Chapter : CoachingBase
    {
        #region fields
        public int Chapter_ID;
        public int Class_ID;
        public int Subject_ID;
        public string Chapter_Name;
        public string Chapter_Description;
        #endregion fields

        #region Save Methods
        /// <summary>
        /// Object Specific - Mehod to build string for insert data into db
        /// </summary>
        /// <returns></returns>
        override public string buildStringForInsert()
        {
            string FieldNames = "";
            string FieldValues = "";

            if (Chapter_ID != 0 && Chapter_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Chapter.Chapter_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Chapter_ID);// Coming from C# FORM
            }

            if (Class_ID != 0 && Class_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Chapter.Class_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Class_ID);// Coming from C# FORM
            }

            if (Subject_ID != 0 && Subject_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Chapter.Subject_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Subject_ID);// Coming from C# FORM
            }


            if (!string.IsNullOrEmpty(Chapter_Name))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Chapter.Chapter_Name.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Chapter_Name);// Coming from C# FORM
            }

            if (!string.IsNullOrEmpty(Chapter_Description))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Chapter.Chapter_Description.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Chapter_Description);// Coming from C# FORM
            }



            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.Chapter.ToString(), FieldNames, FieldValues);

            return insertIntoString;

        }
        #endregion Save Method

        #region Query
        /// <summary>
        /// Object Specific function
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        override public object convertFromReader(OleDbDataReader dr)
        {
            Chapter gotFromDB = new Chapter();            
            gotFromDB.Chapter_ID = int.Parse(dr[DatabaseCoachingInst.Chapter.Chapter_ID.ToString()].ToString());
            gotFromDB.Class_ID = int.Parse(dr[DatabaseCoachingInst.Chapter.Class_ID.ToString()].ToString());
            gotFromDB.Subject_ID = int.Parse(dr[DatabaseCoachingInst.Chapter.Subject_ID.ToString()].ToString());

            gotFromDB.Chapter_Name = dr[DatabaseCoachingInst.Chapter.Chapter_Name.ToString()].ToString();
            gotFromDB.Chapter_Description = dr[DatabaseCoachingInst.Chapter.Chapter_Description.ToString()].ToString();
            // write similar code for other fields.
            return gotFromDB;
        }
        /// <summary>
        /// Object spcivic method
        /// </summary>
        /// <returns></returns>
        override public string buildStringForQuery()
        {
            // Select * from User where userName='Vishal' and address='XYZ'
            string queryStr = "";
            if (Chapter_ID != null && Chapter_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Chapter.Chapter_ID.ToString(), Chapter_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (Class_ID != null && Class_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Chapter.Class_ID.ToString(), Class_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (Subject_ID != null && Subject_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Chapter.Subject_ID.ToString(), Subject_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (!string.IsNullOrEmpty(Chapter_Name))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Chapter.Chapter_Name.ToString(), Chapter_Name);   //" User_Name = '" + user_name + "' and";
            }
            if (!string.IsNullOrEmpty(Chapter_Description))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Chapter.Chapter_Description.ToString(), Chapter_Description);   //" User_Name = '" + user_name + "' and";
            }
            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.Chapter.ToString());
            return queryStr;
        }
        #endregion Query
    }
}
