using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class Batch : CoachingBase
    {
        #region fields
        // All fidels of table, name of these fields should be exactly 
        // same as table's field in the database
        private int batch_Id;
        private int class_id;

        public int Class_id
        {
            get { return class_id; }
            set { class_id = value; }
        }

        public int Batch_Id
        {
            get { return batch_Id; }
            set { batch_Id = value; }
        }
        private string batchname;

        public string Batchname
        {
            get { return batchname; }
            set { batchname = value; }
        }
        private string batchdescription;

        public string Batchdescription
        {
            get { return batchdescription; }
            set { batchdescription = value; }
        }

      

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

            if (!string.IsNullOrEmpty(batchdescription))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Batch.BatchDescription.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(batchdescription);// Coming from C# FORM
            }

            if (!string.IsNullOrEmpty(batchname))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Batch.BatchName.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(batchname);// Coming from C# FORM
            }

            if (class_id != 0 && class_id != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Batch.Class_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(class_id);// Coming from C# FORM
            }

            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.Batch.ToString(), FieldNames, FieldValues);

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
            Batch gotFromDB = new Batch();


            gotFromDB.Batch_Id = int.Parse(dr[DatabaseCoachingInst.Batch.Batch_ID.ToString()].ToString());
            gotFromDB.batchname = dr[DatabaseCoachingInst.Batch.BatchName.ToString()].ToString();
            gotFromDB.Batchdescription = dr[DatabaseCoachingInst.Batch.BatchDescription.ToString()].ToString();
            gotFromDB.class_id = int.Parse(dr[DatabaseCoachingInst.Batch.Class_ID.ToString()].ToString());

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


            if (!string.IsNullOrEmpty(batchname))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Batch.BatchName.ToString(), batchname);   //" User_Name = '" + user_name + "' and";
            }

            if (!string.IsNullOrEmpty(Batchdescription))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Batch.BatchDescription.ToString(), Batchdescription);   //" User_Name = '" + user_name + "' and";
            }

            if (Batch_Id != null && Batch_Id != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Batch.Batch_ID.ToString(), Batch_Id);   //" User_Name = '" + user_name + "' and";
            }

            if (class_id != null && class_id != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Batch.Class_ID.ToString(), class_id);   //" User_Name = '" + user_name + "' and";
            }

            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.Batch.ToString());

            return queryStr;
        }

        #endregion Query
    }
}
