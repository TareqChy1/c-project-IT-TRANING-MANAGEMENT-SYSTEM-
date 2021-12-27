namespace ITDbConnection
{
    partial class StudentChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentChangePassword));
            this.Idlabel1 = new System.Windows.Forms.Label();
            this.SubmitButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.IdtextBox1 = new System.Windows.Forms.TextBox();
            this.CurrentPasswordlabel1 = new System.Windows.Forms.Label();
            this.NewPasswordlabel2 = new System.Windows.Forms.Label();
            this.CurrentPasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.NewPasswordtextBox3 = new System.Windows.Forms.TextBox();
            this.LogOutButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ExitButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // Idlabel1
            // 
            this.Idlabel1.AutoSize = true;
            this.Idlabel1.BackColor = System.Drawing.Color.Transparent;
            this.Idlabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idlabel1.ForeColor = System.Drawing.Color.White;
            this.Idlabel1.Location = new System.Drawing.Point(86, 112);
            this.Idlabel1.Name = "Idlabel1";
            this.Idlabel1.Size = new System.Drawing.Size(29, 19);
            this.Idlabel1.TabIndex = 0;
            this.Idlabel1.Text = "ID:";
            // 
            // SubmitButton21
            // 
            this.SubmitButton21.ActiveBorderThickness = 1;
            this.SubmitButton21.ActiveCornerRadius = 20;
            this.SubmitButton21.ActiveFillColor = System.Drawing.Color.MintCream;
            this.SubmitButton21.ActiveForecolor = System.Drawing.Color.White;
            this.SubmitButton21.ActiveLineColor = System.Drawing.Color.GhostWhite;
            this.SubmitButton21.BackColor = System.Drawing.Color.Transparent;
            this.SubmitButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitButton21.BackgroundImage")));
            this.SubmitButton21.ButtonText = "Submit";
            this.SubmitButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton21.ForeColor = System.Drawing.Color.IndianRed;
            this.SubmitButton21.IdleBorderThickness = 1;
            this.SubmitButton21.IdleCornerRadius = 20;
            this.SubmitButton21.IdleFillColor = System.Drawing.Color.Black;
            this.SubmitButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SubmitButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SubmitButton21.Location = new System.Drawing.Point(249, 305);
            this.SubmitButton21.Margin = new System.Windows.Forms.Padding(5);
            this.SubmitButton21.Name = "SubmitButton21";
            this.SubmitButton21.Size = new System.Drawing.Size(138, 33);
            this.SubmitButton21.TabIndex = 1;
            this.SubmitButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubmitButton21.Click += new System.EventHandler(this.SubmitButton21_Click);
            // 
            // IdtextBox1
            // 
            this.IdtextBox1.Location = new System.Drawing.Point(232, 111);
            this.IdtextBox1.Name = "IdtextBox1";
            this.IdtextBox1.Size = new System.Drawing.Size(249, 20);
            this.IdtextBox1.TabIndex = 2;
            this.IdtextBox1.TextChanged += new System.EventHandler(this.EmailtextBox1_TextChanged);
            // 
            // CurrentPasswordlabel1
            // 
            this.CurrentPasswordlabel1.AutoSize = true;
            this.CurrentPasswordlabel1.BackColor = System.Drawing.Color.Transparent;
            this.CurrentPasswordlabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordlabel1.ForeColor = System.Drawing.Color.White;
            this.CurrentPasswordlabel1.Location = new System.Drawing.Point(86, 174);
            this.CurrentPasswordlabel1.Name = "CurrentPasswordlabel1";
            this.CurrentPasswordlabel1.Size = new System.Drawing.Size(139, 19);
            this.CurrentPasswordlabel1.TabIndex = 3;
            this.CurrentPasswordlabel1.Text = "Current Password:";
            // 
            // NewPasswordlabel2
            // 
            this.NewPasswordlabel2.AutoSize = true;
            this.NewPasswordlabel2.BackColor = System.Drawing.Color.Transparent;
            this.NewPasswordlabel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordlabel2.ForeColor = System.Drawing.Color.White;
            this.NewPasswordlabel2.Location = new System.Drawing.Point(86, 229);
            this.NewPasswordlabel2.Name = "NewPasswordlabel2";
            this.NewPasswordlabel2.Size = new System.Drawing.Size(116, 19);
            this.NewPasswordlabel2.TabIndex = 4;
            this.NewPasswordlabel2.Text = "New Password:";
            // 
            // CurrentPasswordtextBox2
            // 
            this.CurrentPasswordtextBox2.Location = new System.Drawing.Point(232, 173);
            this.CurrentPasswordtextBox2.Name = "CurrentPasswordtextBox2";
            this.CurrentPasswordtextBox2.Size = new System.Drawing.Size(249, 20);
            this.CurrentPasswordtextBox2.TabIndex = 5;
            // 
            // NewPasswordtextBox3
            // 
            this.NewPasswordtextBox3.Location = new System.Drawing.Point(232, 228);
            this.NewPasswordtextBox3.Name = "NewPasswordtextBox3";
            this.NewPasswordtextBox3.Size = new System.Drawing.Size(249, 20);
            this.NewPasswordtextBox3.TabIndex = 6;
            // 
            // LogOutButton21
            // 
            this.LogOutButton21.ActiveBorderThickness = 1;
            this.LogOutButton21.ActiveCornerRadius = 20;
            this.LogOutButton21.ActiveFillColor = System.Drawing.Color.MintCream;
            this.LogOutButton21.ActiveForecolor = System.Drawing.Color.White;
            this.LogOutButton21.ActiveLineColor = System.Drawing.Color.GhostWhite;
            this.LogOutButton21.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutButton21.BackgroundImage")));
            this.LogOutButton21.ButtonText = "Log Out";
            this.LogOutButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton21.ForeColor = System.Drawing.Color.IndianRed;
            this.LogOutButton21.IdleBorderThickness = 1;
            this.LogOutButton21.IdleCornerRadius = 20;
            this.LogOutButton21.IdleFillColor = System.Drawing.Color.Black;
            this.LogOutButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.LogOutButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.LogOutButton21.Location = new System.Drawing.Point(249, 348);
            this.LogOutButton21.Margin = new System.Windows.Forms.Padding(5);
            this.LogOutButton21.Name = "LogOutButton21";
            this.LogOutButton21.Size = new System.Drawing.Size(138, 33);
            this.LogOutButton21.TabIndex = 7;
            this.LogOutButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutButton21.Click += new System.EventHandler(this.LogOutButton21_Click);
            // 
            // ExitButton22
            // 
            this.ExitButton22.ActiveBorderThickness = 1;
            this.ExitButton22.ActiveCornerRadius = 20;
            this.ExitButton22.ActiveFillColor = System.Drawing.Color.MintCream;
            this.ExitButton22.ActiveForecolor = System.Drawing.Color.White;
            this.ExitButton22.ActiveLineColor = System.Drawing.Color.GhostWhite;
            this.ExitButton22.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton22.BackgroundImage")));
            this.ExitButton22.ButtonText = "Exit";
            this.ExitButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton22.ForeColor = System.Drawing.Color.IndianRed;
            this.ExitButton22.IdleBorderThickness = 1;
            this.ExitButton22.IdleCornerRadius = 20;
            this.ExitButton22.IdleFillColor = System.Drawing.Color.Black;
            this.ExitButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ExitButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ExitButton22.Location = new System.Drawing.Point(424, 409);
            this.ExitButton22.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton22.Name = "ExitButton22";
            this.ExitButton22.Size = new System.Drawing.Size(138, 33);
            this.ExitButton22.TabIndex = 8;
            this.ExitButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton22.Click += new System.EventHandler(this.ExitButton22_Click);
            // 
            // BackButton21
            // 
            this.BackButton21.ActiveBorderThickness = 1;
            this.BackButton21.ActiveCornerRadius = 20;
            this.BackButton21.ActiveFillColor = System.Drawing.Color.MintCream;
            this.BackButton21.ActiveForecolor = System.Drawing.Color.White;
            this.BackButton21.ActiveLineColor = System.Drawing.Color.GhostWhite;
            this.BackButton21.BackColor = System.Drawing.Color.Transparent;
            this.BackButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton21.BackgroundImage")));
            this.BackButton21.ButtonText = "Back";
            this.BackButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton21.ForeColor = System.Drawing.Color.IndianRed;
            this.BackButton21.IdleBorderThickness = 1;
            this.BackButton21.IdleCornerRadius = 20;
            this.BackButton21.IdleFillColor = System.Drawing.Color.Black;
            this.BackButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BackButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BackButton21.Location = new System.Drawing.Point(249, 399);
            this.BackButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BackButton21.Name = "BackButton21";
            this.BackButton21.Size = new System.Drawing.Size(138, 33);
            this.BackButton21.TabIndex = 9;
            this.BackButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackButton21.Click += new System.EventHandler(this.BackButton21_Click);
            // 
            // StudentChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 446);
            this.Controls.Add(this.BackButton21);
            this.Controls.Add(this.ExitButton22);
            this.Controls.Add(this.LogOutButton21);
            this.Controls.Add(this.NewPasswordtextBox3);
            this.Controls.Add(this.CurrentPasswordtextBox2);
            this.Controls.Add(this.NewPasswordlabel2);
            this.Controls.Add(this.CurrentPasswordlabel1);
            this.Controls.Add(this.IdtextBox1);
            this.Controls.Add(this.SubmitButton21);
            this.Controls.Add(this.Idlabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 SubmitButton21;
        private System.Windows.Forms.TextBox IdtextBox1;
        private System.Windows.Forms.Label CurrentPasswordlabel1;
        private System.Windows.Forms.Label NewPasswordlabel2;
        private System.Windows.Forms.TextBox CurrentPasswordtextBox2;
        private System.Windows.Forms.TextBox NewPasswordtextBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOutButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 ExitButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 BackButton21;
    }
}