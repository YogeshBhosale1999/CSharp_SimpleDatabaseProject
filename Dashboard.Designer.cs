namespace CSharpDatabaseProject
{
	partial class Dashboard
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmpId = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGender = new System.Windows.Forms.TextBox();
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDesignation = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dgvEmpTable = new System.Windows.Forms.DataGridView();
			this.dtHireDate = new System.Windows.Forms.DateTimePicker();
			this.btnClear = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpTable)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1206, 46);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(472, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "EMPLOYEE INFORMATION";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Employee Id";
			// 
			// txtEmpId
			// 
			this.txtEmpId.Location = new System.Drawing.Point(171, 90);
			this.txtEmpId.Name = "txtEmpId";
			this.txtEmpId.Size = new System.Drawing.Size(384, 27);
			this.txtEmpId.TabIndex = 2;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(171, 147);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(384, 27);
			this.txtFirstName.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "First Name";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(171, 201);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(384, 27);
			this.txtLastName.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Last Name";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtGender
			// 
			this.txtGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female",
            "Other"});
			this.txtGender.Location = new System.Drawing.Point(771, 93);
			this.txtGender.Name = "txtGender";
			this.txtGender.Size = new System.Drawing.Size(384, 27);
			this.txtGender.TabIndex = 2;
			// 
			// txtSalary
			// 
			this.txtSalary.Location = new System.Drawing.Point(771, 198);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(384, 27);
			this.txtSalary.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 258);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Email";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(621, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 20);
			this.label6.TabIndex = 1;
			this.label6.Text = "Hire Date";
			this.label6.Click += new System.EventHandler(this.label5_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(621, 198);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 20);
			this.label7.TabIndex = 1;
			this.label7.Text = "Salary";
			this.label7.Click += new System.EventHandler(this.label5_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(171, 258);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(384, 27);
			this.txtEmail.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(621, 90);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 20);
			this.label8.TabIndex = 4;
			this.label8.Text = "Gender";
			this.label8.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtDesignation
			// 
			this.txtDesignation.Location = new System.Drawing.Point(771, 258);
			this.txtDesignation.Name = "txtDesignation";
			this.txtDesignation.Size = new System.Drawing.Size(384, 27);
			this.txtDesignation.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(621, 258);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 20);
			this.label9.TabIndex = 1;
			this.label9.Text = "Designation";
			this.label9.Click += new System.EventHandler(this.label5_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(171, 313);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(94, 29);
			this.btnInsert.TabIndex = 5;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(488, 313);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(94, 29);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1061, 313);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(94, 29);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dgvEmpTable
			// 
			this.dgvEmpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmpTable.Location = new System.Drawing.Point(36, 366);
			this.dgvEmpTable.Name = "dgvEmpTable";
			this.dgvEmpTable.RowHeadersWidth = 51;
			this.dgvEmpTable.RowTemplate.Height = 29;
			this.dgvEmpTable.Size = new System.Drawing.Size(1119, 194);
			this.dgvEmpTable.TabIndex = 6;
			// 
			// dtHireDate
			// 
			this.dtHireDate.Location = new System.Drawing.Point(771, 145);
			this.dtHireDate.Name = "dtHireDate";
			this.dtHireDate.Size = new System.Drawing.Size(384, 27);
			this.dtHireDate.TabIndex = 7;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(747, 313);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(94, 29);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1207, 580);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.dtHireDate);
			this.Controls.Add(this.dgvEmpTable);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDesignation);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtSalary);
			this.Controls.Add(this.txtGender);
			this.Controls.Add(this.txtEmpId);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private TextBox txtEmpId;
		private TextBox txtFirstName;
		private Label label3;
		private TextBox txtLastName;
		private Label label4;
		private TextBox txtGender;
		private TextBox txtSalary;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox txtEmail;
		private Label label8;
		private TextBox txtDesignation;
		private Label label9;
		private Button btnInsert;
		private Button btnUpdate;
		private Button btnDelete;
		private DataGridView dgvEmpTable;
		private DateTimePicker dtHireDate;
		private Button btnClear;
	}
}