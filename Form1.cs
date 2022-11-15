using System.Data.SqlClient;

namespace CSharpDatabaseProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection scon = new SqlConnection("Data Source =LAPTOP-CJ3G61MK; Database =Maxwell; Integrated Security=True");

			scon.Open();

			SqlCommand cmd = new SqlCommand("Select * from Accounts Where UserName='"+txtUsername.Text+"' and UserPassword='"+txtPassword.Text+"'",scon);
			
			SqlDataReader sdr;
			sdr = cmd.ExecuteReader();


			if (sdr.Read())
			{
				Dashboard ds = new Dashboard();
				ds.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Incorrect Username or Password","Message Title",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

			scon.Close();
		}
	}
}