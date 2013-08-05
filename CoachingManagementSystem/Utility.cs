using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoachingManagementSystem
{
    public class DatabaseCoachingInst
    {
        // Contains constants
        public enum Tables { 
            User,
            UserRole,
            Class,
            Batch
        }

        public enum User
        {
            user_id,
            user_name,
            user_role_id,
            Address,
            Phone,
            email,
            password
        }

        public enum UserRole
        {
            User_Role_ID,
            UserRole,
            AccessControl
        }


        public enum Class
        { 
            Class_id,
            ClassName,
            ClassDescription
        }

        public enum Batch
        {
            Batch_ID,
            BatchName,
            BatchDescription
        }
        // Constains small util functions
    }

    public class utility {
        public static void AddDeleteAndEditButton(DataGridView dgv)
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Edit";
            col.Name = "Edit";
            dgv.Columns.Add(col);


            DataGridViewButtonColumn col2 = new DataGridViewButtonColumn();
            col2.UseColumnTextForButtonValue = true;
            col2.Text = "Delete";
            col2.Name = "Delete";
            dgv.Columns.Add(col2);
        }
    
    
    }
}
