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
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {

        }

        private void GET_Click(object sender, EventArgs e)
        {          

            user queryobject = new user();
            queryobject.Address = Address_TextBox.Text;
            queryobject.User_name = User_Name_TextBox.Text;
            queryobject.Email_id = Email_TextBox.Text;
            if (UserRole.SelectedValue != null)
            {
                queryobject.User_role_id = int.Parse(UserRole.SelectedValue.ToString());
            }
            queryobject.Phone = Phone_TextBox.Text;
            queryobject.Passwrod = Password_textBox1.Text;

            List<object> dataRet = queryobject.get();
            List<user> data = new List<user>();
            foreach (object o in dataRet)
            {
                data.Add(o as user);
            }

            var _bind = data.Select(a => new
            {
                UserID = a.User_id,
                Address = a.Address,
                Email = a.Email_id,
                Phone = a.Phone,
                Name = a.User_name,
                UserRole = a.User_role_id,
                Password = a.Passwrod,

               
            }).ToList();

            UserDataGrid.DataSource = _bind;

            utility.AddDeleteAndEditButton(UserDataGrid);

            // Link for getting buttons working as part of grid.
            // http://stackoverflow.com/questions/10769316/add-a-button-in-a-new-column-to-all-rows-in-a-datagrid

            UserDataGrid.Update();
        }


    }
}
