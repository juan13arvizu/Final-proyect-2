namespace Rehabilitation_Clinic_JIZ
{
    partial class MainAccess
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Directionlabel = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.AdminBotton = new System.Windows.Forms.Button();
            this.PatientsBotton = new System.Windows.Forms.Button();
            this.SpecialistBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Directionlabel
            // 
            this.Directionlabel.AutoSize = true;
            this.Directionlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Directionlabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directionlabel.ForeColor = System.Drawing.Color.Black;
            this.Directionlabel.Location = new System.Drawing.Point(12, 84);
            this.Directionlabel.Name = "Directionlabel";
            this.Directionlabel.Size = new System.Drawing.Size(211, 27);
            this.Directionlabel.TabIndex = 17;
            this.Directionlabel.Text = "Select your profile:";
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.LogoLabel.Font = new System.Drawing.Font("Braga", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Location = new System.Drawing.Point(193, 20);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(376, 37);
            this.LogoLabel.TabIndex = 16;
            this.LogoLabel.Text = "Clínica de Rehabilitación JIZ";
            // 
            // AdminBotton
            // 
            this.AdminBotton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AdminBotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminBotton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBotton.ForeColor = System.Drawing.Color.Transparent;
            this.AdminBotton.Location = new System.Drawing.Point(527, 250);
            this.AdminBotton.Name = "AdminBotton";
            this.AdminBotton.Size = new System.Drawing.Size(136, 35);
            this.AdminBotton.TabIndex = 14;
            this.AdminBotton.Text = "Admin";
            this.AdminBotton.UseVisualStyleBackColor = false;
            this.AdminBotton.Click += new System.EventHandler(this.AdminBotton_Click);
            // 
            // PatientsBotton
            // 
            this.PatientsBotton.BackColor = System.Drawing.Color.DodgerBlue;
            this.PatientsBotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PatientsBotton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsBotton.ForeColor = System.Drawing.Color.MintCream;
            this.PatientsBotton.Location = new System.Drawing.Point(76, 250);
            this.PatientsBotton.Name = "PatientsBotton";
            this.PatientsBotton.Size = new System.Drawing.Size(136, 35);
            this.PatientsBotton.TabIndex = 13;
            this.PatientsBotton.Text = "Patients";
            this.PatientsBotton.UseVisualStyleBackColor = false;
            this.PatientsBotton.Click += new System.EventHandler(this.PatientsBotton_Click);
            // 
            // SpecialistBotton
            // 
            this.SpecialistBotton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SpecialistBotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpecialistBotton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialistBotton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SpecialistBotton.Location = new System.Drawing.Point(277, 175);
            this.SpecialistBotton.Name = "SpecialistBotton";
            this.SpecialistBotton.Size = new System.Drawing.Size(193, 40);
            this.SpecialistBotton.TabIndex = 15;
            this.SpecialistBotton.Text = "Specialist ";
            this.SpecialistBotton.UseVisualStyleBackColor = false;
            this.SpecialistBotton.Click += new System.EventHandler(this.SpecialistBotton_Click);
            // 
            // MainAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(726, 365);
            this.Controls.Add(this.Directionlabel);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.AdminBotton);
            this.Controls.Add(this.PatientsBotton);
            this.Controls.Add(this.SpecialistBotton);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainAccess";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainAccess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Directionlabel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Button AdminBotton;
        private System.Windows.Forms.Button PatientsBotton;
        private System.Windows.Forms.Button SpecialistBotton;
    }
}

