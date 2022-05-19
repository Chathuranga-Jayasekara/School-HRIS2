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
    public partial class ViewStaffForm : Form
    {
        public ViewStaffForm()
        {
            InitializeComponent();
        }

        private void ViewStaffForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetstaffList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bind_data();
        }
        private DataTable GetstaffList()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            using (SqlCommand command = new SqlCommand("SELECT * FROM staff", con))
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);

            }
            return dt;

        }

        private void bind_data()
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            SqlCommand command = new SqlCommand("SELECT id, givenname, familyname,title,campus,phone,room,email,photo FROM staff WHERE  (givenname LIKE @query OR familyname LIKE @query)", con);
            command.Parameters.AddWithValue("@query", txtsearchTitle.Text);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //Hide();
                StaffForm staffForm = new StaffForm();
               

                staffForm.txt_Id.Text = row.Cells["id"].Value.ToString();
                staffForm.txt_GName.Text = row.Cells["givenname"].Value.ToString();
                staffForm.txt_FName.Text = row.Cells["familyname"].Value.ToString();
                staffForm.txt_Title.Text = row.Cells["title"].Value.ToString();
                staffForm.txt_Campus.Text = row.Cells["campus"].Value.ToString();
                staffForm.txt_Phone.Text = row.Cells["phone"].Value.ToString();
                staffForm.txt_Room.Text = row.Cells["room"].Value.ToString();
                staffForm.txt_Email.Text = row.Cells["email"].Value.ToString();
                staffForm.pictureBox1.Text = row.Cells["photo"].Value.ToString();
                staffForm.ShowDialog();
                Show();



            }


        }
    }
}
