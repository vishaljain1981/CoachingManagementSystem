using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class ChapterTracking : CoachingBase
    {
        #region fields
        public int ChapterTracking_ID;
        public int Chapter_ID;
        public int Batch_ID;
        public bool? GDDone;
        public bool? PSSDone;
        public bool? TestDone;
        public bool? NumericalTestDone;
        public int VerifiedBy_ID;
        public string Remarks;
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
            if (ChapterTracking_ID != 0 && ChapterTracking_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.ChapterTracking_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(ChapterTracking_ID);// Coming from C# FORM
            }
            if (Chapter_ID != 0 && Chapter_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.Chapter_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Chapter_ID);// Coming from C# FORM
            }
            if (Batch_ID != 0 && Batch_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.Batch_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Batch_ID);// Coming from C# FORM
            }
            if (VerifiedBy_ID != 0 && VerifiedBy_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.VerifiedBy_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(VerifiedBy_ID);// Coming from C# FORM
            }
            if (!string.IsNullOrEmpty(Remarks))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.Remarks.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Remarks);// Coming from C# FORM
            }
            if (GDDone != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.GDDone.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(GDDone);// Coming from C# FORM
            }
            if (PSSDone != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.PSSDone.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(PSSDone);// Coming from C# FORM
            }
            if (TestDone != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.TestDone.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(TestDone);// Coming from C# FORM
            }
            if (NumericalTestDone != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ChapterTracking.NumericalTestDone.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(NumericalTestDone);// Coming from C# FORM
            }
            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.ChapterTracking.ToString(), FieldNames, FieldValues);
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
            ChapterTracking gotFromDB = new ChapterTracking();
            gotFromDB.ChapterTracking_ID = int.Parse(dr[DatabaseCoachingInst.ChapterTracking.ChapterTracking_ID.ToString()].ToString());
            gotFromDB.Chapter_ID = int.Parse(dr[DatabaseCoachingInst.ChapterTracking.Chapter_ID.ToString()].ToString());
            gotFromDB.Batch_ID = int.Parse(dr[DatabaseCoachingInst.ChapterTracking.Batch_ID.ToString()].ToString());
            gotFromDB.VerifiedBy_ID = int.Parse(dr[DatabaseCoachingInst.ChapterTracking.VerifiedBy_ID.ToString()].ToString());
            gotFromDB.Remarks = dr[DatabaseCoachingInst.ChapterTracking.Remarks.ToString()].ToString();
            gotFromDB.GDDone = bool.Parse(dr[DatabaseCoachingInst.ChapterTracking.GDDone.ToString()].ToString());
            gotFromDB.PSSDone = bool.Parse(dr[DatabaseCoachingInst.ChapterTracking.PSSDone.ToString()].ToString());
            gotFromDB.TestDone = bool.Parse(dr[DatabaseCoachingInst.ChapterTracking.TestDone.ToString()].ToString());

            gotFromDB.NumericalTestDone = bool.Parse(dr[DatabaseCoachingInst.ChapterTracking.NumericalTestDone.ToString()].ToString());


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
            if (ChapterTracking_ID != null && ChapterTracking_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.ChapterTracking_ID.ToString(), ChapterTracking_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (Chapter_ID != null && Chapter_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.Chapter_ID.ToString(), Chapter_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (Batch_ID != null && Batch_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.Batch_ID.ToString(), Batch_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (VerifiedBy_ID != null && VerifiedBy_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.VerifiedBy_ID.ToString(), VerifiedBy_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (!string.IsNullOrEmpty(Remarks))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.Remarks.ToString(), Remarks);   //" User_Name = '" + user_name + "' and";
            }

            if (GDDone != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.GDDone.ToString(), GDDone);   //" User_Name = '" + user_name + "' and";
            }

            if (PSSDone != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.PSSDone.ToString(), PSSDone);   //" User_Name = '" + user_name + "' and";
            }

            if (TestDone != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.TestDone.ToString(), TestDone);   //" User_Name = '" + user_name + "' and";
            }

            if (NumericalTestDone != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ChapterTracking.NumericalTestDone.ToString(), NumericalTestDone);   //" User_Name = '" + user_name + "' and";
            }

            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.ChapterTracking.ToString());
            return queryStr;
        }
        #endregion Query
    }
}
