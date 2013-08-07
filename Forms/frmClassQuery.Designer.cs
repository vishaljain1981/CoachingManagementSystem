namespace CoachingManagementSystem
{
    partial class frmClassQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassDescription = new System.Windows.Forms.TextBox();
            this.lblClassId = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClassDescription = new System.Windows.Forms.Label();
            this.btnClassQuery = new System.Windows.Forms.Button();
            this.dataGridClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(139, 53);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(100, 20);
            this.txtClassID.TabIndex = 0;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(361, 53);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 20);
            this.txtClassName.TabIndex = 1;
            // 
            // txtClassDescription
            // 
            this.txtClassDescription.Location = new System.Drawing.Point(629, 54);
            this.txtClassDescription.Name = "txtClassDescription";
            this.txtClassDescription.Size = new System.Drawing.Size(100, 20);
            this.txtClassDescription.TabIndex = 2;
            // 
            // lblClassId
            // 
            this.lblClassId.AutoSize = true;
            this.lblClassId.Location = new System.Drawing.Point(54, 56);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(46, 13);
            this.lblClassId.TabIndex = 3;
            this.lblClassId.Text = "Class ID";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(273, 57);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(63, 13);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Class Name";
            // 
            // lblClassDescription
            // 
            this.lblClassDescription.AutoSize = true;
            this.lblClassDescription.Location = new System.Drawing.Point(513, 57);
            this.lblClassDescription.Name = "lblClassDescription";
            this.lblClassDescription.Size = new System.Drawing.Size(88, 13);
            this.lblClassDescription.TabIndex = 5;
            this.lblClassDescription.Text = "Class Description";
            // 
            // btnClassQuery
            // 
            this.btnClassQuery.Location = new System.Drawing.Point(361, 143);
            this.btnClassQuery.Name = "btnClassQuery";
            this.btnClassQuery.Size = new System.Drawing.Size(75, 23);
            this.btnClassQuery.TabIndex = 6;
            this.btnClassQuery.Text = "Get Class";
            this.btnClassQuery.UseVisualStyleBackColor = true;
            this.btnClassQuery.Click += new System.EventHandler(this.btnClassQuery_Click);
            // 
            // dataGridClass
            // 
            this.dataGridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClass.Location = new System.Drawing.Point(57, 172);
            this.dataGridClass.Name = "dataGridClass";
            this.dataGridClass.Size = new System.Drawing.Size(672, 290);
            this.dataGridClass.TabIndex = 7;
            // 
            // frmClassQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 518);
            this.Controls.Add(this.dataGridClass);
            this.Controls.Add(this.btnClassQuery);
            this.Controls.Add(this.lblClassDescription);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblClassId);
            this.Controls.Add(this.txtClassDescription);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassID);
            this.Name = "frmClassQuery";
            this.Text = "frmClassQuery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassDescription;
        private System.Windows.Forms.Label lblClassId;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClassDescription;
        private System.Windows.Forms.Button btnClassQuery;
        private System.Windows.Forms.DataGridView dataGridClass;
    }
}