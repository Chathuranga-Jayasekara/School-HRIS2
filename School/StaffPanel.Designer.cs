
namespace School
{
    partial class StaffPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPanel));
            this.btn_viewunit = new System.Windows.Forms.Button();
            this.btn_viewclass = new System.Windows.Forms.Button();
            this.btn_viewstaff = new System.Windows.Forms.Button();
            this.btn_viewcons = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_viewunit
            // 
            this.btn_viewunit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_viewunit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_viewunit.Location = new System.Drawing.Point(3, 47);
            this.btn_viewunit.Name = "btn_viewunit";
            this.btn_viewunit.Size = new System.Drawing.Size(247, 63);
            this.btn_viewunit.TabIndex = 0;
            this.btn_viewunit.Text = "View all units";
            this.btn_viewunit.UseVisualStyleBackColor = false;
            this.btn_viewunit.Click += new System.EventHandler(this.btn_viewunit_Click);
            // 
            // btn_viewclass
            // 
            this.btn_viewclass.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_viewclass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_viewclass.Location = new System.Drawing.Point(-1, 234);
            this.btn_viewclass.Name = "btn_viewclass";
            this.btn_viewclass.Size = new System.Drawing.Size(250, 58);
            this.btn_viewclass.TabIndex = 1;
            this.btn_viewclass.Text = "View all classes";
            this.btn_viewclass.UseVisualStyleBackColor = false;
            this.btn_viewclass.Click += new System.EventHandler(this.btn_viewclass_Click);
            // 
            // btn_viewstaff
            // 
            this.btn_viewstaff.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_viewstaff.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_viewstaff.Location = new System.Drawing.Point(0, 141);
            this.btn_viewstaff.Name = "btn_viewstaff";
            this.btn_viewstaff.Size = new System.Drawing.Size(247, 58);
            this.btn_viewstaff.TabIndex = 2;
            this.btn_viewstaff.Text = "View all staff";
            this.btn_viewstaff.UseVisualStyleBackColor = false;
            this.btn_viewstaff.Click += new System.EventHandler(this.btn_viewstaff_Click);
            // 
            // btn_viewcons
            // 
            this.btn_viewcons.BackColor = System.Drawing.Color.Lavender;
            this.btn_viewcons.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_viewcons.Location = new System.Drawing.Point(-3, 340);
            this.btn_viewcons.Name = "btn_viewcons";
            this.btn_viewcons.Size = new System.Drawing.Size(247, 58);
            this.btn_viewcons.TabIndex = 3;
            this.btn_viewcons.Text = "View all consultations";
            this.btn_viewcons.UseVisualStyleBackColor = false;
            this.btn_viewcons.Click += new System.EventHandler(this.btn_viewcons_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 65);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Support Staff";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_viewunit);
            this.panel1.Controls.Add(this.btn_viewstaff);
            this.panel1.Controls.Add(this.btn_viewcons);
            this.panel1.Controls.Add(this.btn_viewclass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 518);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 518);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "University of Tasmania";
            // 
            // StaffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 583);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "StaffPanel";
            this.Text = "StaffPanel";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewunit;
        private System.Windows.Forms.Button btn_viewclass;
        private System.Windows.Forms.Button btn_viewstaff;
        private System.Windows.Forms.Button btn_viewcons;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}