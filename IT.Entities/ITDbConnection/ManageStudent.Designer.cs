namespace ITDbConnection
{
    partial class ManageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudent));
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.InsertButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.StudentdataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusradioButton1 = new System.Windows.Forms.RadioButton();
            this.StudentNametextBox1 = new System.Windows.Forms.TextBox();
            this.Addresslabel1 = new System.Windows.Forms.Label();
            this.Genderlabel4 = new System.Windows.Forms.Label();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.UpdateButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RemoveButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LogOutButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ExitButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActiveradioButton1 = new System.Windows.Forms.RadioButton();
            this.RefreshbunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.StudentNameLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.ForeColor = System.Drawing.Color.White;
            this.StudentNameLabel.Location = new System.Drawing.Point(12, 74);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(110, 19);
            this.StudentNameLabel.TabIndex = 0;
            this.StudentNameLabel.Text = "Student Name:";
            // 
            // InsertButton
            // 
            this.InsertButton.ActiveBorderThickness = 1;
            this.InsertButton.ActiveCornerRadius = 20;
            this.InsertButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.InsertButton.ActiveForecolor = System.Drawing.Color.White;
            this.InsertButton.ActiveLineColor = System.Drawing.Color.White;
            this.InsertButton.BackColor = System.Drawing.SystemColors.Control;
            this.InsertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InsertButton.BackgroundImage")));
            this.InsertButton.ButtonText = "Insert";
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.InsertButton.IdleBorderThickness = 1;
            this.InsertButton.IdleCornerRadius = 20;
            this.InsertButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.InsertButton.IdleForecolor = System.Drawing.Color.White;
            this.InsertButton.IdleLineColor = System.Drawing.Color.White;
            this.InsertButton.Location = new System.Drawing.Point(16, 326);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(5);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(106, 30);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // StudentdataGridView1
            // 
            this.StudentdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentdataGridView1.Location = new System.Drawing.Point(310, 64);
            this.StudentdataGridView1.Name = "StudentdataGridView1";
            this.StudentdataGridView1.Size = new System.Drawing.Size(264, 220);
            this.StudentdataGridView1.TabIndex = 2;
            this.StudentdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridView1_CellClick);
            // 
            // StatusradioButton1
            // 
            this.StatusradioButton1.AutoSize = true;
            this.StatusradioButton1.BackColor = System.Drawing.Color.Transparent;
            this.StatusradioButton1.ForeColor = System.Drawing.Color.White;
            this.StatusradioButton1.Location = new System.Drawing.Point(134, 18);
            this.StatusradioButton1.Name = "StatusradioButton1";
            this.StatusradioButton1.Size = new System.Drawing.Size(31, 17);
            this.StatusradioButton1.TabIndex = 3;
            this.StatusradioButton1.TabStop = true;
            this.StatusradioButton1.Text = "2";
            this.StatusradioButton1.UseVisualStyleBackColor = false;
            // 
            // StudentNametextBox1
            // 
            this.StudentNametextBox1.Location = new System.Drawing.Point(128, 73);
            this.StudentNametextBox1.Name = "StudentNametextBox1";
            this.StudentNametextBox1.Size = new System.Drawing.Size(176, 20);
            this.StudentNametextBox1.TabIndex = 4;
            // 
            // Addresslabel1
            // 
            this.Addresslabel1.AutoSize = true;
            this.Addresslabel1.BackColor = System.Drawing.Color.Transparent;
            this.Addresslabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel1.ForeColor = System.Drawing.Color.White;
            this.Addresslabel1.Location = new System.Drawing.Point(12, 124);
            this.Addresslabel1.Name = "Addresslabel1";
            this.Addresslabel1.Size = new System.Drawing.Size(81, 19);
            this.Addresslabel1.TabIndex = 5;
            this.Addresslabel1.Text = "Password:";
            // 
            // Genderlabel4
            // 
            this.Genderlabel4.AutoSize = true;
            this.Genderlabel4.BackColor = System.Drawing.Color.Transparent;
            this.Genderlabel4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlabel4.ForeColor = System.Drawing.Color.White;
            this.Genderlabel4.Location = new System.Drawing.Point(12, 242);
            this.Genderlabel4.Name = "Genderlabel4";
            this.Genderlabel4.Size = new System.Drawing.Size(101, 19);
            this.Genderlabel4.TabIndex = 8;
            this.Genderlabel4.Text = "Active Status:";
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(128, 123);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.Size = new System.Drawing.Size(176, 20);
            this.PasswordtextBox2.TabIndex = 9;
            // 
            // UpdateButton22
            // 
            this.UpdateButton22.ActiveBorderThickness = 1;
            this.UpdateButton22.ActiveCornerRadius = 20;
            this.UpdateButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.UpdateButton22.ActiveForecolor = System.Drawing.Color.White;
            this.UpdateButton22.ActiveLineColor = System.Drawing.Color.White;
            this.UpdateButton22.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateButton22.BackgroundImage")));
            this.UpdateButton22.ButtonText = "Update";
            this.UpdateButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton22.ForeColor = System.Drawing.Color.White;
            this.UpdateButton22.IdleBorderThickness = 1;
            this.UpdateButton22.IdleCornerRadius = 20;
            this.UpdateButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.UpdateButton22.IdleForecolor = System.Drawing.Color.White;
            this.UpdateButton22.IdleLineColor = System.Drawing.Color.White;
            this.UpdateButton22.Location = new System.Drawing.Point(150, 326);
            this.UpdateButton22.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateButton22.Name = "UpdateButton22";
            this.UpdateButton22.Size = new System.Drawing.Size(113, 30);
            this.UpdateButton22.TabIndex = 13;
            this.UpdateButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateButton22.Click += new System.EventHandler(this.UpdateButton22_Click);
            // 
            // RemoveButton23
            // 
            this.RemoveButton23.ActiveBorderThickness = 1;
            this.RemoveButton23.ActiveCornerRadius = 20;
            this.RemoveButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.RemoveButton23.ActiveForecolor = System.Drawing.Color.White;
            this.RemoveButton23.ActiveLineColor = System.Drawing.Color.White;
            this.RemoveButton23.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveButton23.BackgroundImage")));
            this.RemoveButton23.ButtonText = "Remove";
            this.RemoveButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton23.ForeColor = System.Drawing.Color.White;
            this.RemoveButton23.IdleBorderThickness = 1;
            this.RemoveButton23.IdleCornerRadius = 20;
            this.RemoveButton23.IdleFillColor = System.Drawing.Color.Transparent;
            this.RemoveButton23.IdleForecolor = System.Drawing.Color.White;
            this.RemoveButton23.IdleLineColor = System.Drawing.Color.White;
            this.RemoveButton23.Location = new System.Drawing.Point(291, 326);
            this.RemoveButton23.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveButton23.Name = "RemoveButton23";
            this.RemoveButton23.Size = new System.Drawing.Size(113, 30);
            this.RemoveButton23.TabIndex = 14;
            this.RemoveButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RemoveButton23.Click += new System.EventHandler(this.RemoveButton23_Click);
            // 
            // BackButton24
            // 
            this.BackButton24.ActiveBorderThickness = 1;
            this.BackButton24.ActiveCornerRadius = 20;
            this.BackButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BackButton24.ActiveForecolor = System.Drawing.Color.White;
            this.BackButton24.ActiveLineColor = System.Drawing.Color.White;
            this.BackButton24.BackColor = System.Drawing.SystemColors.Control;
            this.BackButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton24.BackgroundImage")));
            this.BackButton24.ButtonText = "Back";
            this.BackButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton24.ForeColor = System.Drawing.Color.White;
            this.BackButton24.IdleBorderThickness = 1;
            this.BackButton24.IdleCornerRadius = 20;
            this.BackButton24.IdleFillColor = System.Drawing.Color.Transparent;
            this.BackButton24.IdleForecolor = System.Drawing.Color.White;
            this.BackButton24.IdleLineColor = System.Drawing.Color.White;
            this.BackButton24.Location = new System.Drawing.Point(448, 326);
            this.BackButton24.Margin = new System.Windows.Forms.Padding(5);
            this.BackButton24.Name = "BackButton24";
            this.BackButton24.Size = new System.Drawing.Size(113, 30);
            this.BackButton24.TabIndex = 15;
            this.BackButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackButton24.Click += new System.EventHandler(this.BackButton24_Click);
            // 
            // LogOutButton25
            // 
            this.LogOutButton25.ActiveBorderThickness = 1;
            this.LogOutButton25.ActiveCornerRadius = 20;
            this.LogOutButton25.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.LogOutButton25.ActiveForecolor = System.Drawing.Color.White;
            this.LogOutButton25.ActiveLineColor = System.Drawing.Color.White;
            this.LogOutButton25.BackColor = System.Drawing.SystemColors.Control;
            this.LogOutButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutButton25.BackgroundImage")));
            this.LogOutButton25.ButtonText = "Log Out";
            this.LogOutButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton25.ForeColor = System.Drawing.Color.White;
            this.LogOutButton25.IdleBorderThickness = 1;
            this.LogOutButton25.IdleCornerRadius = 20;
            this.LogOutButton25.IdleFillColor = System.Drawing.Color.Transparent;
            this.LogOutButton25.IdleForecolor = System.Drawing.Color.White;
            this.LogOutButton25.IdleLineColor = System.Drawing.Color.White;
            this.LogOutButton25.Location = new System.Drawing.Point(450, 390);
            this.LogOutButton25.Margin = new System.Windows.Forms.Padding(5);
            this.LogOutButton25.Name = "LogOutButton25";
            this.LogOutButton25.Size = new System.Drawing.Size(113, 30);
            this.LogOutButton25.TabIndex = 16;
            this.LogOutButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutButton25.Click += new System.EventHandler(this.LogOutButton25_Click);
            // 
            // ExitButton21
            // 
            this.ExitButton21.ActiveBorderThickness = 1;
            this.ExitButton21.ActiveCornerRadius = 20;
            this.ExitButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ExitButton21.ActiveForecolor = System.Drawing.Color.White;
            this.ExitButton21.ActiveLineColor = System.Drawing.Color.White;
            this.ExitButton21.BackColor = System.Drawing.SystemColors.Control;
            this.ExitButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton21.BackgroundImage")));
            this.ExitButton21.ButtonText = "Exit";
            this.ExitButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton21.ForeColor = System.Drawing.Color.White;
            this.ExitButton21.IdleBorderThickness = 1;
            this.ExitButton21.IdleCornerRadius = 20;
            this.ExitButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.ExitButton21.IdleForecolor = System.Drawing.Color.White;
            this.ExitButton21.IdleLineColor = System.Drawing.Color.White;
            this.ExitButton21.Location = new System.Drawing.Point(291, 390);
            this.ExitButton21.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton21.Name = "ExitButton21";
            this.ExitButton21.Size = new System.Drawing.Size(113, 30);
            this.ExitButton21.TabIndex = 17;
            this.ExitButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton21.Click += new System.EventHandler(this.ExitButton21_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StatusradioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 53);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = " Status:";
            // 
            // ActiveradioButton1
            // 
            this.ActiveradioButton1.AutoSize = true;
            this.ActiveradioButton1.BackColor = System.Drawing.Color.Transparent;
            this.ActiveradioButton1.ForeColor = System.Drawing.Color.White;
            this.ActiveradioButton1.Location = new System.Drawing.Point(150, 244);
            this.ActiveradioButton1.Name = "ActiveradioButton1";
            this.ActiveradioButton1.Size = new System.Drawing.Size(31, 17);
            this.ActiveradioButton1.TabIndex = 20;
            this.ActiveradioButton1.TabStop = true;
            this.ActiveradioButton1.Text = "1";
            this.ActiveradioButton1.UseVisualStyleBackColor = false;
            // 
            // RefreshbunifuThinButton21
            // 
            this.RefreshbunifuThinButton21.ActiveBorderThickness = 1;
            this.RefreshbunifuThinButton21.ActiveCornerRadius = 20;
            this.RefreshbunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.RefreshbunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.RefreshbunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.RefreshbunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshbunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshbunifuThinButton21.BackgroundImage")));
            this.RefreshbunifuThinButton21.ButtonText = "Refresh";
            this.RefreshbunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshbunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshbunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.RefreshbunifuThinButton21.IdleBorderThickness = 1;
            this.RefreshbunifuThinButton21.IdleCornerRadius = 20;
            this.RefreshbunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.RefreshbunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.RefreshbunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.RefreshbunifuThinButton21.Location = new System.Drawing.Point(16, 366);
            this.RefreshbunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshbunifuThinButton21.Name = "RefreshbunifuThinButton21";
            this.RefreshbunifuThinButton21.Size = new System.Drawing.Size(106, 39);
            this.RefreshbunifuThinButton21.TabIndex = 21;
            this.RefreshbunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshbunifuThinButton21.Click += new System.EventHandler(this.RefreshbunifuThinButton21_Click);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(577, 434);
            this.Controls.Add(this.RefreshbunifuThinButton21);
            this.Controls.Add(this.StudentdataGridView1);
            this.Controls.Add(this.ActiveradioButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton21);
            this.Controls.Add(this.LogOutButton25);
            this.Controls.Add(this.BackButton24);
            this.Controls.Add(this.RemoveButton23);
            this.Controls.Add(this.UpdateButton22);
            this.Controls.Add(this.PasswordtextBox2);
            this.Controls.Add(this.Genderlabel4);
            this.Controls.Add(this.Addresslabel1);
            this.Controls.Add(this.StudentNametextBox1);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.StudentNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentNameLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 InsertButton;
        private System.Windows.Forms.DataGridView StudentdataGridView1;
        private System.Windows.Forms.RadioButton StatusradioButton1;
        private System.Windows.Forms.TextBox StudentNametextBox1;
        private System.Windows.Forms.Label Addresslabel1;
        private System.Windows.Forms.Label Genderlabel4;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 RemoveButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 BackButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOutButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 ExitButton21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ActiveradioButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshbunifuThinButton21;
    }
}