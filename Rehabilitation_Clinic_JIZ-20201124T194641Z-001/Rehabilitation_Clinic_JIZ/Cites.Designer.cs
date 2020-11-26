namespace Rehabilitation_Clinic_JIZ
{
    partial class Cites
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
            this.label10 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.PUserBoxtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ReButton1 = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Procedur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dayofbirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Blue;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.White;
            this.LogoLabel.Location = new System.Drawing.Point(159, 20);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(482, 39);
            this.LogoLabel.TabIndex = 22;
            this.LogoLabel.Text = "Clínica de Rehabilitación JIZ";
            this.LogoLabel.Click += new System.EventHandler(this.LogoLabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SpringGreen;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 30);
            this.label10.TabIndex = 44;
            this.label10.Text = "Patients";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Username,
            this.Password,
            this.FirstName,
            this.LastName,
            this.EmailAddress,
            this.Procedur,
            this.Dayofbirth});
            this.listView2.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(31, 203);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(561, 258);
            this.listView2.TabIndex = 38;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // PUserBoxtxt
            // 
            this.PUserBoxtxt.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUserBoxtxt.Location = new System.Drawing.Point(31, 132);
            this.PUserBoxtxt.Name = "PUserBoxtxt";
            this.PUserBoxtxt.Size = new System.Drawing.Size(172, 22);
            this.PUserBoxtxt.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 30);
            this.label8.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Khaki;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 30);
            this.label9.TabIndex = 39;
            this.label9.Text = "Username";
            // 
            // ReButton1
            // 
            this.ReButton1.BackColor = System.Drawing.Color.DarkOrchid;
            this.ReButton1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReButton1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ReButton1.Location = new System.Drawing.Point(374, 482);
            this.ReButton1.Name = "ReButton1";
            this.ReButton1.Size = new System.Drawing.Size(115, 34);
            this.ReButton1.TabIndex = 46;
            this.ReButton1.Text = "Refresh";
            this.ReButton1.UseVisualStyleBackColor = false;
            this.ReButton1.Click += new System.EventHandler(this.ReButton1_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 42;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 128;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 129;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 126;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 145;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Text = "EmailAddress";
            this.EmailAddress.Width = 173;
            // 
            // Procedur
            // 
            this.Procedur.Text = "Procedur";
            this.Procedur.Width = 118;
            // 
            // Dayofbirth
            // 
            this.Dayofbirth.Text = "Dayofbirth";
            this.Dayofbirth.Width = 139;
            // 
            // Cites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 528);
            this.Controls.Add(this.ReButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PUserBoxtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.LogoLabel);
            this.Name = "Cites";
            this.Text = "CITIES";
            this.Load += new System.EventHandler(this.Cites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox PUserBoxtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ReButton1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader EmailAddress;
        private System.Windows.Forms.ColumnHeader Procedur;
        private System.Windows.Forms.ColumnHeader Dayofbirth;
    }
}