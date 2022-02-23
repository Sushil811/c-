using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CsharpwithDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Things neeeded
            //1.SqlConnection
            //2.SqlCommand
            //3.SqlDataReader
            
            SqlConnection con = new SqlConnection("Data Source=Localhost;Database=CSharp Tut;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Account Where Username"+txtusername.Text+"' and Passsword= '"+txtPassword.Text+"'", con);
            SqlDataReader sdr;
            sdr= cmd.ExecuteReader();


            if(sdr.Read())
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect username or Password","Message Title",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
