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
    public partial class frmAddBatch : Form
    {
        public frmAddBatch()
        {
            InitializeComponent();
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            // Create Object
            Batch newObj = new Batch();
            newObj.Batchname = txtBatchName.Text;
            newObj.Batchdescription = txtBatchDescription.Text;
            // Assign read form's fields to object's fields

            // Call Save
            newObj.save();

            // http://tech.pro/tutorial/776/csharp-tutorial-binding-a-datagridview-to-a-collection

            this.Close();
        }
    }
}
