namespace Rehabilitation_Clinic_JIZ
{
    partial class Admin
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
            this.LogoLabel = new System.Windows.Forms.Label();
            this.PswBoxtxt1 = new System.Windows.Forms.TextBox();
            this.LoginBotton1 = new System.Windows.Forms.Button();
            this.PswBoxlabel = new System.Windows.Forms.Label();
            this.UserBoxtxt1 = new System.Windows.Forms.TextBox();
            this.UserBoxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecialistButton = new System.Windows.Forms.Button();
            this.PatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Blue;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.White;
            this.LogoLabel.Location = new System.Drawing.Point(202, 9);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(448, 37);
            this.LogoLabel.TabIndex = 33;
            this.LogoLabel.Text = "Clínica de Rehabilitación JIZ";
            // 
            // PswBoxtxt1
            // 
            this.PswBoxtxt1.Location = new System.Drawing.Point(470, 124);
            this.PswBoxtxt1.Name = "PswBoxtxt1";
            this.PswBoxtxt1.Size = new System.Drawing.Size(167, 34);
            this.PswBoxtxt1.TabIndex = 34;
            this.PswBoxtxt1.UseSystemPasswordChar = true;
            this.PswBoxtxt1.TextChanged += new System.EventHandler(this.PswBoxtxt1_TextChanged);
            // 
            // LoginBotton1
            // 
            this.LoginBotton1.BackColor = System.Drawing.Color.Violet;
            this.LoginBotton1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBotton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBotton1.Location = new System.Drawing.Point(298, 244);
            this.LoginBotton1.Name = "LoginBotton1";
            this.LoginBotton1.Size = new System.Drawing.Size(132, 38);
            this.LoginBotton1.TabIndex = 35;
            this.LoginBotton1.Text = "Log in";
            this.LoginBotton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginBotton1.UseVisualStyleBackColor = false;
            this.LoginBotton1.Click += new System.EventHandler(this.LoginBotton1_Click);
            // 
            // PswBoxlabel
            // 
            this.PswBoxlabel.AutoSize = true;
            this.PswBoxlabel.BackColor = System.Drawing.Color.Lavender;
            this.PswBoxlabel.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PswBoxlabel.ForeColor = System.Drawing.Color.Black;
            this.PswBoxlabel.Location = new System.Drawing.Point(494, 71);
            this.PswBoxlabel.Name = "PswBoxlabel";
            this.PswBoxlabel.Size = new System.Drawing.Size(119, 30);
            this.PswBoxlabel.TabIndex = 32;
            this.PswBoxlabel.Text = "Password";
            // 
            // UserBoxtxt1
            // 
            this.UserBoxtxt1.Location = new System.Drawing.Point(44, 124);
            this.UserBoxtxt1.Name = "UserBoxtxt1";
            this.UserBoxtxt1.Size = new System.Drawing.Size(166, 34);
            this.UserBoxtxt1.TabIndex = 36;
            this.UserBoxtxt1.TextChanged += new System.EventHandler(this.UserBoxtxt1_TextChanged);
            // 
            // UserBoxLabel
            // 
            this.UserBoxLabel.AutoSize = true;
            this.UserBoxLabel.BackColor = System.Drawing.Color.Lavender;
            this.UserBoxLabel.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBoxLabel.ForeColor = System.Drawing.Color.Black;
            this.UserBoxLabel.Location = new System.Drawing.Point(73, 71);
            this.UserBoxLabel.Name = "UserBoxLabel";
            this.UserBoxLabel.Size = new System.Drawing.Size(124, 30);
            this.UserBoxLabel.TabIndex = 31;
            this.UserBoxLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(293, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "Choose user";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 44;
            // 
            // SpecialistButton
            // 
            this.SpecialistButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SpecialistButton.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialistButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpecialistButton.Location = new System.Drawing.Point(21, 339);
            this.SpecialistButton.Name = "SpecialistButton";
            this.SpecialistButton.Size = new System.Drawing.Size(176, 35);
            this.SpecialistButton.TabIndex = 41;
            this.SpecialistButton.Text = "SPECIALIST";
            this.SpecialistButton.UseVisualStyleBackColor = false;
            this.SpecialistButton.Click += new System.EventHandler(this.SpecialistButton_Click);
            // 
            // PatientButton
            // 
            this.PatientButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PatientButton.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientButton.Location = new System.Drawing.Point(554, 339);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(147, 35);
            this.PatientButton.TabIndex = 43;
            this.PatientButton.Text = "PATIENT";
            this.PatientButton.UseVisualStyleBackColor = false;
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 395);
            this.Controls.Add(this.PatientButton);
            this.Controls.Add(this.SpecialistButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.PswBoxtxt1);
            this.Controls.Add(this.LoginBotton1);
            this.Controls.Add(this.PswBoxlabel);
            this.Controls.Add(this.UserBoxtxt1);
            this.Controls.Add(this.UserBoxLabel);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Admin";
            this.Text = "                                                                                 " +
    "                               ";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.TextBox PswBoxtxt1;
        private System.Windows.Forms.Button LoginBotton1;
        private System.Windows.Forms.Label PswBoxlabel;
        private System.Windows.Forms.TextBox UserBoxtxt1;
        private System.Windows.Forms.Label UserBoxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SpecialistButton;
        private System.Windows.Forms.Button PatientButton;
    }
}