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
    public partial class ViewClassForm : Form
    {
        public ViewClassForm()
        {
            InitializeComponent();
        }
        private DataTable GetClassList()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Properties.Resources.connetionString);
            using (SqlCommand command = new SqlCommand("SELECT * FROM class", con))
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
            SqlCommand command = new SqlCommand("SELECT id, unit_code, campus,day, starttime,endtime,type,room,staff FROM class WHERE  (staff LIKE @query OR unit_code LIKE @query)", con);
            command.Parameters.AddWithValue("@query", txtsearchTitle.Text);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;


        }

    

        private void ViewClassForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetClassList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bind_data();
        }
    }
    
}
