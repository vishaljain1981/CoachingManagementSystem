namespace CoachingManagementSystem
{
    partial class AddUserRoleForm
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coachingManagementSystem1DataSet = new CoachingManagementSystem.CoachingManagementSystem1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.coachingManagementSystem1DataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // coachingManagementSystem1DataSet
            // 
            this.coachingManagementSystem1DataSet.DataSetName = "CoachingManagementSystem1DataSet";
            this.coachingManagementSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Role";
            // 
            // UserRole
            // 
            this.UserRole.Location = new System.Drawing.Point(72, 50);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(100, 20);
            this.UserRole.TabIndex = 1;
            this.UserRole.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(78, 113);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(63, 24);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // AddUserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 166);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.UserRole);
            this.Controls.Add(this.label1);
            this.Name = "AddUserRoleForm";
            this.Text = "Add User Role";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private CoachingManagementSystem1DataSet coachingManagementSystem1DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserRole;
        private System.Windows.Forms.Button OK;
    }
}