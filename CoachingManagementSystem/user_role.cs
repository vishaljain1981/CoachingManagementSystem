using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoachingManagementSystem
{
    class user_role
    {
        private string UserRole;

        public string UserRole1
        {
            get { return UserRole; }
            set { UserRole = value; }
        }      


        /* Public Methods */
        public void save()
        {
            DBHelper dbhelper = new DBHelper();
            string insertstr = buildStringForInsert();
            dbhelper.ExecuteNonQuery(insertstr);
            dbhelper.close();

        }

        private string buildStringForInsert()
        {
            string FieldNames = "";
            string FieldValues = "";
#if qwer
            if (!string.IsNullOrEmpty(UserRole))
            {
                FieldNames += ",[User_Name]";
                FieldValues += ",'" + UserRole + "'";
            }

            if (!string.IsNullOrEmpty(address))
            {
                FieldNames += ",[ADDRESS]";
                FieldValues += ",'" + address + "'";
            }

            if (!string.IsNullOrEmpty(phone))
            {
                FieldNames += ",[Phone]";
                FieldValues += ",'" + phone + "'";
            }

            if (!string.IsNullOrEmpty(email_id))
            {
                FieldNames += ",[email]";
                FieldValues += ",'" + email_id + "'";
            }

            if (!string.IsNullOrEmpty(passwrod))
            {
                FieldNames += ",[password]";
                FieldValues += ",'" + passwrod + "'";
            }

            if (user_role_id != null)
            {
                //DBHelper dbhelper = new DBHelper();
                //dbhelper.ExecuteQuery("Select * from User_Role where User_Role_Name = " + user)
                // How are we mapping user_role given by user in combobox with its id?
                //selected value of combobox corresponding to selected member 
                FieldNames += ",[User_Role_ID]";
                FieldValues += "," + user_role_id + "";
            }

            FieldNames = FieldNames.Trim(',');
            FieldValues = FieldValues.Trim(',');

            string insertIntoString = "Insert Into [User] (" + FieldNames + ") Values (" + FieldValues + ")";

            return insertIntoString;
#endif
            return "";


        }
    }
}
