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
    public partial class frmClassQuery : Form
    {
        public frmClassQuery()
        {
            InitializeComponent();
        }

        private void btnClassQuery_Click(object sender, EventArgs e)
        {
            Class queryobject = new Class();
            if (!String.IsNullOrEmpty(txtClassID.Text))
            {
                queryobject.Class_id = int.Parse(txtClassID.Text);
            }
            queryobject.ClassDescription = txtClassDescription.Text;
            queryobject.ClassName = txtClassName.Text;

            List<object> dataRet = queryobject.get();
            List<Class> data = new List<Class>();
            foreach (object o in dataRet)
            {
                data.Add(o as Class);
            }

            var _bind = data.Select(a => new
            {
                ClassID = a.Class_id,
                ClassName = a.ClassName,
                ClassDescription = a.ClassDescription,


            }).ToList();

            dataGridClass.DataSource = _bind;

            utility.AddDeleteAndEditButton(dataGridClass);

            // Link for getting buttons working as part of grid.
            // http://stackoverflow.com/questions/10769316/add-a-button-in-a-new-column-to-all-rows-in-a-datagrid

            dataGridClass.Update();
        }

       
    }
}
