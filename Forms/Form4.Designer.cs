namespace CoachingManagementSystem
{
    partial class AddUserForm
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
            this.UserRole = new System.Windows.Forms.ComboBox();
            this.userRoleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coachingManagementSystem1DataSet = new CoachingManagementSystem.CoachingManagementSystem1DataSet();
            this.userRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachingManagementSystem1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRoleTableAdapter = new CoachingManagementSystem.CoachingManagementSystem1DataSetTableAdapters.UserRoleTableAdapter();
            this.User_Name_GroupBox = new System.Windows.Forms.GroupBox();
            this.User_Name_TextBox = new System.Windows.Forms.TextBox();
            this.User_Name_Label = new System.Windows.Forms.Label();
            this.User_Role_ID_GroupBox = new System.Windows.Forms.GroupBox();
            this.User_Role_ID_Label = new System.Windows.Forms.Label();
            this.Address_GroupBox = new System.Windows.Forms.GroupBox();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Phone_GroupBox = new System.Windows.Forms.GroupBox();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.Email_GroupBox = new System.Windows.Forms.GroupBox();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Email_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Password_groupBox2 = new System.Windows.Forms.GroupBox();
            this.Password_textBox1 = new System.Windows.Forms.TextBox();
            this.Password_label1 = new System.Windows.Forms.Label();
            this.UserDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSetBindingSource)).BeginInit();
            this.User_Name_GroupBox.SuspendLayout();
            this.User_Role_ID_GroupBox.SuspendLayout();
            this.Address_GroupBox.SuspendLayout();
            this.Phone_GroupBox.SuspendLayout();
            this.Email_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Password_groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserRole
            // 
            this.UserRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userRoleBindingSource1, "UserRole", true));
            this.UserRole.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.userRoleBindingSource1, "UserRole", true));
            this.UserRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.userRoleBindingSource1, "UserRole", true));
            this.UserRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userRoleBindingSource1, "UserRole", true));
            this.UserRole.DataSource = this.userRoleBindingSource;
            this.UserRole.DisplayMember = "UserRole";
            this.UserRole.FormattingEnabled = true;
            this.UserRole.Location = new System.Drawing.Point(49, 69);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(239, 21);
            this.UserRole.TabIndex = 0;
            this.UserRole.ValueMember = "User_Role_ID";
            //this.UserRole.SelectedIndexChanged += new System.EventHandler(this.UserRole_SelectedIndexChanged);
            // 
            // userRoleBindingSource1
            // 
            this.userRoleBindingSource1.DataMember = "UserRole";
            this.userRoleBindingSource1.DataSource = this.coachingManagementSystem1DataSet;
            // 
            // coachingManagementSystem1DataSet
            // 
            this.coachingManagementSystem1DataSet.DataSetName = "CoachingManagementSystem1DataSet";
            this.coachingManagementSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userRoleBindingSource
            // 
            this.userRoleBindingSource.DataMember = "UserRole";
            this.userRoleBindingSource.DataSource = this.coachingManagementSystem1DataSet;
            // 
            // coachingManagementSystem1DataSetBindingSource
            // 
            this.coachingManagementSystem1DataSetBindingSource.DataSource = this.coachingManagementSystem1DataSet;
            this.coachingManagementSystem1DataSetBindingSource.Position = 0;
            // 
            // userRoleTableAdapter
            // 
            this.userRoleTableAdapter.ClearBeforeFill = true;
            // 
            // User_Name_GroupBox
            // 
            this.User_Name_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.User_Name_GroupBox.Controls.Add(this.User_Name_TextBox);
            this.User_Name_GroupBox.Controls.Add(this.User_Name_Label);
            this.User_Name_GroupBox.Location = new System.Drawing.Point(272, 12);
            this.User_Name_GroupBox.Name = "User_Name_GroupBox";
            this.User_Name_GroupBox.Size = new System.Drawing.Size(343, 78);
            this.User_Name_GroupBox.TabIndex = 1;
            this.User_Name_GroupBox.TabStop = false;
            this.User_Name_GroupBox.Text = "User_Name";
            // 
            // User_Name_TextBox
            // 
            this.User_Name_TextBox.Location = new System.Drawing.Point(49, 52);
            this.User_Name_TextBox.Name = "User_Name_TextBox";
            this.User_Name_TextBox.Size = new System.Drawing.Size(239, 20);
            this.User_Name_TextBox.TabIndex = 1;
            this.User_Name_TextBox.Text = "User_Name";
            //this.User_Name_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // User_Name_Label
            // 
            this.User_Name_Label.AutoSize = true;
            this.User_Name_Label.Location = new System.Drawing.Point(132, 16);
            this.User_Name_Label.Name = "User_Name_Label";
            this.User_Name_Label.Size = new System.Drawing.Size(63, 13);
            this.User_Name_Label.TabIndex = 0;
            this.User_Name_Label.Text = "User_Name";
            // 
            // User_Role_ID_GroupBox
            // 
            this.User_Role_ID_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.User_Role_ID_GroupBox.Controls.Add(this.User_Role_ID_Label);
            this.User_Role_ID_GroupBox.Controls.Add(this.UserRole);
            this.User_Role_ID_GroupBox.Location = new System.Drawing.Point(272, 97);
            this.User_Role_ID_GroupBox.Name = "User_Role_ID_GroupBox";
            this.User_Role_ID_GroupBox.Size = new System.Drawing.Size(343, 139);
            this.User_Role_ID_GroupBox.TabIndex = 2;
            this.User_Role_ID_GroupBox.TabStop = false;
            this.User_Role_ID_GroupBox.Text = "User_Role_ID";
            // 
            // User_Role_ID_Label
            // 
            this.User_Role_ID_Label.AutoSize = true;
            this.User_Role_ID_Label.Location = new System.Drawing.Point(132, 26);
            this.User_Role_ID_Label.Name = "User_Role_ID_Label";
            this.User_Role_ID_Label.Size = new System.Drawing.Size(74, 13);
            this.User_Role_ID_Label.TabIndex = 0;
            this.User_Role_ID_Label.Text = "User_Role_ID";
            // 
            // Address_GroupBox
            // 
            this.Address_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Address_GroupBox.Controls.Add(this.Address_TextBox);
            this.Address_GroupBox.Controls.Add(this.Address_Label);
            this.Address_GroupBox.Location = new System.Drawing.Point(272, 243);
            this.Address_GroupBox.Name = "Address_GroupBox";
            this.Address_GroupBox.Size = new System.Drawing.Size(343, 100);
            this.Address_GroupBox.TabIndex = 3;
            this.Address_GroupBox.TabStop = false;
            this.Address_GroupBox.Text = "Address";
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(49, 55);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(239, 20);
            this.Address_TextBox.TabIndex = 1;
            this.Address_TextBox.Text = "Address";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(132, 16);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(45, 13);
            this.Address_Label.TabIndex = 0;
            this.Address_Label.Text = "Address";
            // 
            // Phone_GroupBox
            // 
            this.Phone_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Phone_GroupBox.Controls.Add(this.Phone_TextBox);
            this.Phone_GroupBox.Controls.Add(this.Phone_Label);
            this.Phone_GroupBox.Location = new System.Drawing.Point(272, 350);
            this.Phone_GroupBox.Name = "Phone_GroupBox";
            this.Phone_GroupBox.Size = new System.Drawing.Size(343, 100);
            this.Phone_GroupBox.TabIndex = 4;
            this.Phone_GroupBox.TabStop = false;
            this.Phone_GroupBox.Text = "Phone";
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(49, 52);
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(239, 20);
            this.Phone_TextBox.TabIndex = 1;
            this.Phone_TextBox.Text = "Phone";
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Location = new System.Drawing.Point(135, 20);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(38, 13);
            this.Phone_Label.TabIndex = 0;
            this.Phone_Label.Text = "Phone";
            // 
            // Email_GroupBox
            // 
            this.Email_GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Email_GroupBox.Controls.Add(this.Email_TextBox);
            this.Email_GroupBox.Controls.Add(this.Email_Label);
            this.Email_GroupBox.Location = new System.Drawing.Point(272, 457);
            this.Email_GroupBox.Name = "Email_GroupBox";
            this.Email_GroupBox.Size = new System.Drawing.Size(343, 100);
            this.Email_GroupBox.TabIndex = 5;
            this.Email_GroupBox.TabStop = false;
            this.Email_GroupBox.Text = "Email";
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(49, 49);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(239, 20);
            this.Email_TextBox.TabIndex = 1;
            this.Email_TextBox.Text = "Email";
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Location = new System.Drawing.Point(138, 20);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(32, 13);
            this.Email_Label.TabIndex = 0;
            this.Email_Label.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(272, 656);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Submit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(138, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password_groupBox2
            // 
            this.Password_groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Password_groupBox2.Controls.Add(this.Password_textBox1);
            this.Password_groupBox2.Controls.Add(this.Password_label1);
            this.Password_groupBox2.Location = new System.Drawing.Point(272, 563);
            this.Password_groupBox2.Name = "Password_groupBox2";
            this.Password_groupBox2.Size = new System.Drawing.Size(343, 87);
            this.Password_groupBox2.TabIndex = 7;
            this.Password_groupBox2.TabStop = false;
            this.Password_groupBox2.Text = "Password";
            // 
            // Password_textBox1
            // 
            this.Password_textBox1.Location = new System.Drawing.Point(49, 55);
            this.Password_textBox1.Name = "Password_textBox1";
            this.Password_textBox1.Size = new System.Drawing.Size(239, 20);
            this.Password_textBox1.TabIndex = 1;
            this.Password_textBox1.Text = "Password";
            // 
            // Password_label1
            // 
            this.Password_label1.AutoSize = true;
            this.Password_label1.Location = new System.Drawing.Point(141, 20);
            this.Password_label1.Name = "Password_label1";
            this.Password_label1.Size = new System.Drawing.Size(53, 13);
            this.Password_label1.TabIndex = 0;
            this.Password_label1.Text = "Password";
            // 
            // UserDataGrid
            // 
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid.Location = new System.Drawing.Point(12, 12);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.Size = new System.Drawing.Size(240, 339);
            this.UserDataGrid.TabIndex = 8;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 780);
            this.Controls.Add(this.UserDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Password_groupBox2);
            this.Controls.Add(this.Email_GroupBox);
            this.Controls.Add(this.Phone_GroupBox);
            this.Controls.Add(this.Address_GroupBox);
            this.Controls.Add(this.User_Role_ID_GroupBox);
            this.Controls.Add(this.User_Name_GroupBox);
            this.Name = "AddUserForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSetBindingSource)).EndInit();
            this.User_Name_GroupBox.ResumeLayout(false);
            this.User_Name_GroupBox.PerformLayout();
            this.User_Role_ID_GroupBox.ResumeLayout(false);
            this.User_Role_ID_GroupBox.PerformLayout();
            this.Address_GroupBox.ResumeLayout(false);
            this.Address_GroupBox.PerformLayout();
            this.Phone_GroupBox.ResumeLayout(false);
            this.Phone_GroupBox.PerformLayout();
            this.Email_GroupBox.ResumeLayout(false);
            this.Email_GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Password_groupBox2.ResumeLayout(false);
            this.Password_groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox UserRole;
        private System.Windows.Forms.BindingSource coachingManagementSystem1DataSetBindingSource;
        private CoachingManagementSystem1DataSet coachingManagementSystem1DataSet;
        private System.Windows.Forms.BindingSource userRoleBindingSource;
        private CoachingManagementSystem1DataSetTableAdapters.UserRoleTableAdapter userRoleTableAdapter;
        private System.Windows.Forms.BindingSource userRoleBindingSource1;
        private System.Windows.Forms.GroupBox User_Name_GroupBox;
        private System.Windows.Forms.TextBox User_Name_TextBox;
        private System.Windows.Forms.Label User_Name_Label;
        private System.Windows.Forms.GroupBox User_Role_ID_GroupBox;
        private System.Windows.Forms.Label User_Role_ID_Label;
        private System.Windows.Forms.GroupBox Address_GroupBox;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.GroupBox Phone_GroupBox;
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.GroupBox Email_GroupBox;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Password_groupBox2;
        private System.Windows.Forms.TextBox Password_textBox1;
        private System.Windows.Forms.Label Password_label1;
        private System.Windows.Forms.DataGridView UserDataGrid;
    }
}