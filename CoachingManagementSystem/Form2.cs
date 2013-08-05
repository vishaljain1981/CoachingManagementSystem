using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoachingManagementSystem
{
    public partial class AddUserRoleForm : Form
    {
        public AddUserRoleForm()
        {
            InitializeComponent();
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void OK_Click(object sender, EventArgs e)
        {            
        }        
        private void OK_Click_1(object sender, EventArgs e)
        {
            DBHelper dbhelper = new DBHelper();
            string string1 = "insert into UserRole(UserRole) values('" + UserRole.Text + "')";
            dbhelper.ExecuteNonQuery(string1);
            dbhelper.close();
            this.Close();
        }        
    }
}
