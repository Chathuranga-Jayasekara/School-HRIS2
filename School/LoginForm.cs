using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //utils.createAdmin("123");
        }

        private void button_login_Click_1(object sender, EventArgs e)
        {
            string connetionString = School.Properties.Resources.connetionString;
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT user_id FROM [user] where user_username =@username AND user_password = @password ";
            command.Parameters.AddWithValue("@username", textBox_username.Text);
            command.Parameters.AddWithValue("@password", textBox_password.Text);
            con.Open();
            var result = command.ExecuteScalar();
            con.Close();
            if (result != null)
            {
                if (textBox_username.Text == "admin")
                {
                    Hide();
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.ShowDialog();
                    Show();
                }
                else
                {
                    con.Open();
                    command.CommandText = "SELECT account_id ,account_type FROM account WHERE account_user_id=@user_id";
                    command.Parameters.AddWithValue("@user_id", result.ToString());
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int account_id = reader.GetInt32(0);
                        int account_type = reader.GetInt32(1);

                        con.Close();

                        if (account_type == 0)
                        {
                            //Staff Panel
                            Hide();
                            StaffPanel staffPanel = new StaffPanel(account_id);
                            staffPanel.ShowDialog();
                            Show();
                        }
                        else if (account_type == 1)
                        {
                            //Student Panel
                            Hide();
                            StudentPanel studentPanel = new StudentPanel(account_id);
                            studentPanel.ShowDialog();
                            Show();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Authentication Failed");
            }
        }
    }
}
