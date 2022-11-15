using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDatabaseProject
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SqlConnection scon = new SqlConnection("Data Source =LAPTOP-CJ3G61MK; Database =Maxwell; Integrated Security=True");

			scon.Open();

			SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Employees]([Employee Id],[First Name],[Last Name],[Email],[Gender],[Salary],[Designation],[Hire Date])VALUES ('"+txtEmpId.Text+"','"+txtFirstName.Text+"','"+txtLastName.Text+"','"+txtEmail.Text+"','"+txtGender.Text+"','"+txtSalary.Text+"','"+txtDesignation.Text+"','"+dtHireDate.Value+"')", scon);

			cmd.ExecuteNonQuery();

			MessageBox.Show("Record Saved Successfully","Message Title",MessageBoxButtons.OK,MessageBoxIcon.Information);

			loadEmployeesRecord();

			scon.Close();
		
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			SqlConnection scon = new SqlConnection("Data Source =LAPTOP-CJ3G61MK; Database =Maxwell; Integrated Security=True");

			scon.Open();

			SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Employees] SET [First Name] ='"+ txtFirstName.Text + "',[Last Name] ='"+ txtLastName.Text + "',[Email] ='"+ txtEmail.Text + "',[Gender] ='"+ txtGender.Text + "',[Salary] ='"+ txtSalary.Text + "',[Designation] ='"+ txtDesignation.Text + "',[Hire Date] ='"+ dtHireDate.Value + "' where [Employee Id] ='"+txtEmpId.Text+"' ", scon);

			cmd.ExecuteNonQuery();

			MessageBox.Show("Record Updated Successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

			loadEmployeesRecord();

			scon.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			SqlConnection scon = new SqlConnection("Data Source =LAPTOP-CJ3G61MK; Database =Maxwell; Integrated Security=True");

			scon.Open();

			SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Employees] WHERE [Employee Id] ='" + txtEmpId.Text + "' ", scon);

			cmd.ExecuteNonQuery();

			MessageBox.Show("Record Deleted Successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

			loadEmployeesRecord();

			scon.Close();
		}

		private void loadEmployeesRecord()
		{
			SqlConnection scon = new SqlConnection("Data Source =LAPTOP-CJ3G61MK; Database =Maxwell; Integrated Security=True");

			scon.Open();

			SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Employees]", scon);

			SqlDataAdapter adapter = new SqlDataAdapter();

			adapter.SelectCommand = cmd;
			
			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);

			BindingSource bindingSource = new BindingSource();

			bindingSource.DataSource = dataTable;

			dgvEmpTable.DataSource = bindingSource;

			adapter.Update(dataTable);

			scon.Close();
		}
		private void Dashboard_Load(object sender, EventArgs e)
		{
			loadEmployeesRecord();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtEmpId.Text = string.Empty;
			txtEmpId.Text = string.Empty;
			txtFirstName.Text = string.Empty;
			txtLastName.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtDesignation.Text = string.Empty;
			txtGender.Text = string.Empty;
			txtSalary.Text = string.Empty;

			loadEmployeesRecord();
		}
	}
}
