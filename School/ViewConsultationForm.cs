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
    public partial class ViewConsultationForm : Form
    {
        public ViewConsultationForm()
        {
            InitializeComponent();
        }

        private void ViewConsultationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetconsultationList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bind_data();
        }

        private DataTable GetconsultationList()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            using (SqlCommand command = new SqlCommand("SELECT * FROM consultation", con))
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
            SqlCommand command = new SqlCommand("SELECT con_id, staff_id, starttime,endtime,day FROM consultation WHERE  (staff_id LIKE @query OR day LIKE @query)", con);
            command.Parameters.AddWithValue("@query", txtsearchTitle.Text);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
