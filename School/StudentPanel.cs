using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School
{
    public partial class StudentPanel : Form
    {
        int account_id;
        public StudentPanel(int id )
        {
            InitializeComponent();
            account_id = id;
        }

        private void btn_viewclass_Click(object sender, EventArgs e)
        {
            Hide();
            ViewClassForm viewClassForm = new ViewClassForm();
            viewClassForm.ShowDialog();
            Show();
        }

        private void btn_viewcons_Click(object sender, EventArgs e)
        {
            Hide();
            ViewConsultationForm viewConsultationForm = new ViewConsultationForm();
            viewConsultationForm.ShowDialog();
            Show();
        }
    }
}
