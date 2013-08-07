using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class Topic : CoachingBase
    {
        #region fields
           public int Topic_ID;
           public int Chapter_ID;
           public string Topic_Name;
           public string Topic_Description;
        #endregion

        #region Save Methods
        /// <summary>
        /// Object Specific - Mehod to build string for insert data into db
        /// </summary>
        /// <returns></returns>
        override public string buildStringForInsert()
        {
            string FieldNames = "";
            string FieldValues = "";

            #region int
            if (Chapter_ID != 0 && Chapter_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Topic.Chapter_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Chapter_ID);// Coming from C# FORM
            }
            #endregion

            #region string
            if (!string.IsNullOrEmpty(Topic_Name))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Topic.Topic_Name.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Topic_Name);// Coming from C# FORM
            }

            if (!string.IsNullOrEmpty(Topic_Description))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Topic.Topic_Description.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Topic_Description);// Coming from C# FORM
            }
            #endregion

           
            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.Topic.ToString(), FieldNames, FieldValues);

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
            Topic gotFromDB = new Topic();
            #region int
            gotFromDB.Topic_ID = int.Parse(dr[DatabaseCoachingInst.Topic.Topic_ID.ToString()].ToString());
            gotFromDB.Chapter_ID = int.Parse(dr[DatabaseCoachingInst.Topic.Chapter_ID.ToString()].ToString());
            #endregion


            gotFromDB.Topic_Name = dr[DatabaseCoachingInst.Topic.Topic_Name.ToString()].ToString();
            gotFromDB.Topic_Description = dr[DatabaseCoachingInst.Topic.Topic_Description.ToString()].ToString();

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

            #region int
            if (Topic_ID != null && Topic_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Topic.Topic_ID.ToString(), Topic_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (Chapter_ID != null && Chapter_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Topic.Chapter_ID.ToString(), Chapter_ID);   //" User_Name = '" + user_name + "' and";
            }

            #endregion
            if (!string.IsNullOrEmpty(Topic_Name))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Topic.Topic_Name.ToString(), Topic_Name);
            }
            if (!string.IsNullOrEmpty(Topic_Description))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Topic.Topic_Description.ToString(), Topic_Description);
            }
            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.Topic.ToString());
            return queryStr;
        }

        #endregion Query
    }
}
