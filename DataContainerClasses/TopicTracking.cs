using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class TopicTracking : CoachingBase
    {
        #region fields
        public int TopicTracking_ID;
        public int Topic_ID;
        public int Batch_ID;
        public int CoverPercentage;
        public int Lecture_ID;
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
            if (Topic_ID != 0 && Topic_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.TopicTracking.Topic_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Topic_ID);// Coming from C# FORM
            }
                        if (Batch_ID != 0 && Batch_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.TopicTracking.Batch_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Batch_ID);// Coming from C# FORM
            }
                        if (CoverPercentage != 0 && CoverPercentage != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.TopicTracking.Topic_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Topic_ID);// Coming from C# FORM
            }
                        if (Lecture_ID != 0 && Lecture_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.TopicTracking.Lecture_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Lecture_ID);// Coming from C# FORM
            }
            #endregion
            
            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.TopicTracking.ToString(), FieldNames, FieldValues);

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
            TopicTracking gotFromDB = new TopicTracking();

            #region int
            gotFromDB.TopicTracking_ID = int.Parse(dr[DatabaseCoachingInst.TopicTracking.TopicTracking_ID.ToString()].ToString());
            gotFromDB.Topic_ID = int.Parse(dr[DatabaseCoachingInst.TopicTracking.Topic_ID.ToString()].ToString());
            gotFromDB.Batch_ID = int.Parse(dr[DatabaseCoachingInst.TopicTracking.Batch_ID.ToString()].ToString());
            gotFromDB.CoverPercentage = int.Parse(dr[DatabaseCoachingInst.TopicTracking.CoverPercentage.ToString()].ToString());
            gotFromDB.Lecture_ID = int.Parse(dr[DatabaseCoachingInst.TopicTracking.Lecture_ID.ToString()].ToString());
            #endregion

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
            if (TopicTracking_ID != null && TopicTracking_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.TopicTracking.TopicTracking_ID.ToString(), TopicTracking_ID);   //" User_Name = '" + user_name + "' and";
            }

            if (Topic_ID != null && Topic_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.TopicTracking.Topic_ID.ToString(), Topic_ID);   //" User_Name = '" + user_name + "' and";
            }

            if (Batch_ID != null && Batch_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.TopicTracking.Batch_ID.ToString(), Batch_ID);   //" User_Name = '" + user_name + "' and";
            }

            if (CoverPercentage != null && CoverPercentage != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.TopicTracking.CoverPercentage.ToString(), Topic_ID);   //" User_Name = '" + user_name + "' and";
            }

            if (Lecture_ID != null && Lecture_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.TopicTracking.Lecture_ID.ToString(), Lecture_ID);   //" User_Name = '" + user_name + "' and";
            }

            #endregion

            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.TopicTracking.ToString());
            return queryStr;
        }

        #endregion Query
    }
}
