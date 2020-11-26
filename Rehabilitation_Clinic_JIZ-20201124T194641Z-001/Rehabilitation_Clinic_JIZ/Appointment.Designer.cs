namespace Rehabilitation_Clinic_JIZ
{
    partial class Appointment
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
            this.DocBoxtxt = new System.Windows.Forms.ListBox();
            this.AreaBoxtxt = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UserBoxtxt = new System.Windows.Forms.TextBox();
            this.HourBoxtxt = new System.Windows.Forms.TextBox();
            this.DateBoxtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DocBoxtxt
            // 
            this.DocBoxtxt.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocBoxtxt.FormattingEnabled = true;
            this.DocBoxtxt.ItemHeight = 17;
            this.DocBoxtxt.Items.AddRange(new object[] {
            "Camila Sanchez",
            "Pedro Garcia",
            "Andrea Garcia",
            "Rafael Campos"});
            this.DocBoxtxt.Location = new System.Drawing.Point(570, 319);
            this.DocBoxtxt.Name = "DocBoxtxt";
            this.DocBoxtxt.Size = new System.Drawing.Size(129, 21);
            this.DocBoxtxt.TabIndex = 25;
            this.DocBoxtxt.SelectedIndexChanged += new System.EventHandler(this.DocBoxtxt_SelectedIndexChanged);
            // 
            // AreaBoxtxt
            // 
            this.AreaBoxtxt.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaBoxtxt.FormattingEnabled = true;
            this.AreaBoxtxt.ItemHeight = 17;
            this.AreaBoxtxt.Items.AddRange(new object[] {
            "Analgesic currents",
            "Electrostimulation",
            "Early stimulation",
            "Massage therapy",
            "Physics therapy",
            "Ultrasonic theraphy"});
            this.AreaBoxtxt.Location = new System.Drawing.Point(582, 162);
            this.AreaBoxtxt.Name = "AreaBoxtxt";
            this.AreaBoxtxt.Size = new System.Drawing.Size(142, 21);
            this.AreaBoxtxt.TabIndex = 24;
            this.AreaBoxtxt.SelectedIndexChanged += new System.EventHandler(this.AreaBoxtxt_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Username";
            // 
            // UserBoxtxt
            // 
            this.UserBoxtxt.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBoxtxt.Location = new System.Drawing.Point(337, 207);
            this.UserBoxtxt.Name = "UserBoxtxt";
            this.UserBoxtxt.Size = new System.Drawing.Size(133, 24);
            this.UserBoxtxt.TabIndex = 22;
            this.UserBoxtxt.TextChanged += new System.EventHandler(this.UserBoxtxt_TextChanged);
            // 
            // HourBoxtxt
            // 
            this.HourBoxtxt.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourBoxtxt.Location = new System.Drawing.Point(66, 319);
            this.HourBoxtxt.Name = "HourBoxtxt";
            this.HourBoxtxt.Size = new System.Drawing.Size(131, 24);
            this.HourBoxtxt.TabIndex = 21;
            this.HourBoxtxt.TextChanged += new System.EventHandler(this.HourBoxtxt_TextChanged);
            // 
            // DateBoxtxt
            // 
            this.DateBoxtxt.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBoxtxt.Location = new System.Drawing.Point(52, 162);
            this.DateBoxtxt.Name = "DateBoxtxt";
            this.DateBoxtxt.Size = new System.Drawing.Size(171, 24);
            this.DateBoxtxt.TabIndex = 20;
            this.DateBoxtxt.TextChanged += new System.EventHandler(this.DateBoxtxt_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Doctor / Specialist ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hour (24 clock)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date (yyyy/mm/dd)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "REGISTER YOUR APPOINTMENT";
            // 
            // Appointment
            // 
            this.ClientSize = new System.Drawing.Size(824, 497);
            this.Controls.Add(this.DocBoxtxt);
            this.Controls.Add(this.AreaBoxtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserBoxtxt);
            this.Controls.Add(this.HourBoxtxt);
            this.Controls.Add(this.DateBoxtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ListBox DocBoxtxt;
        private System.Windows.Forms.ListBox AreaBoxtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserBoxtxt;
        private System.Windows.Forms.TextBox HourBoxtxt;
        private System.Windows.Forms.TextBox DateBoxtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}