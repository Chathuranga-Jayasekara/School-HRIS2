using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

 

        

        private void updateList(string query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            SqlCommand command = con.CreateCommand();
            con.Open();
            command.CommandText = "SELECT account_id, account_name, account_type FROM account WHERE account_type in (0, 1) AND (account_name LIKE @query OR account_id LIKE @query) ORDER BY account_type";
            command.Parameters.AddWithValue("@query", query + "%");

            SqlDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
                listBox1.Items.Add(new account(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));

            con.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            updateList("");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            updateList(txtName.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int account_id;
            try
            {
                account_id = ((account)listBox1.SelectedItem).getID();
            }
            catch (Exception)
            {
                return;
            }

            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT user_username, account_name, account_type FROM [user], account WHERE user_id = account_user_id AND account_id=@id";
            command.Parameters.AddWithValue("@id", account_id);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txt_AccID.Text = account_id.ToString();
                txt_Uname.Text = reader.GetValue(0).ToString();
                txt_Accname.Text = reader.GetValue(1).ToString();

                if (reader.GetInt32(2) == 0)
                    txt_AccType.Text = "staff";
                else
                    txt_AccType.Text = "student";
            }

            con.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (!validateInputs())
            {
                MessageBox.Show("Please check the input fields again!");
                return;
            }

            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "INSERT INTO [user] (user_username, user_password) VALUES(@username, @password)";
            command.Parameters.AddWithValue("@username", txtusername.Text);
            command.Parameters.AddWithValue("@password", txtpassword.Text);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
            {
                //We created the record in user table
                command.CommandText = "SELECT user_id FROM [user] WHERE user_username = @username";
                int user_id = (int)command.ExecuteScalar();

                command.CommandText = "INSERT INTO account (account_user_id, account_name, account_type) VALUES (@user_id, @name, @type)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@name", textBox1.Text);
                command.Parameters.AddWithValue("@type", comboBox1.SelectedIndex);

                if (command.ExecuteNonQuery() > 0)
                {
                    //All good => Account created!
                    MessageBox.Show("Account was successfully created!");
                }
                else
                    MessageBox.Show("Error while creating the account!");
            }
            else
                MessageBox.Show("Error while creating the account!");
            con.Close();
            updateList("");
        }

        private bool validateInputs()
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || textBox1.Text == "")
                return false;

            if (comboBox1.SelectedIndex < 0)
                return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Uname.Text == "")
                return;

            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "DELETE FROM [user] WHERE user_username=@username";
            command.Parameters.AddWithValue("@username", txt_Uname.Text);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Account was deleted!");
            else
                MessageBox.Show("Account was not deleted!");
            con.Close();
            updateList("");
            txt_AccID.Clear();
            txt_Uname.Clear();
            txt_Accname.Clear();
            txt_AccType.Clear();
        }


    }
}
