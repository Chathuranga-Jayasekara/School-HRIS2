using MaterialSkin.Controls;
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
    public partial class ViewUnitsForm : Form
    {
        public ViewUnitsForm()
        {
            InitializeComponent();
        }

        private void ViewUnitsForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = GetunitList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private DataTable GetunitList()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            using (SqlCommand command = new SqlCommand("SELECT * FROM unit", con))
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
            SqlCommand command = new SqlCommand("SELECT code, title, coordinator FROM unit WHERE  (title LIKE @query OR code LIKE @query)", con);
            command.Parameters.AddWithValue("@query", txtsearchTitle.Text);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bind_data();
        }
    }
}
