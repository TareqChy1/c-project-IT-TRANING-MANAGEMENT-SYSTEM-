namespace ITDbConnection
{
    partial class StudentShowAllCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentShowAllCourse));
            this.CoursedataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LogOutButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursedataGridView1
            // 
            this.CoursedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursedataGridView1.Location = new System.Drawing.Point(12, 58);
            this.CoursedataGridView1.Name = "CoursedataGridView1";
            this.CoursedataGridView1.Size = new System.Drawing.Size(449, 220);
            this.CoursedataGridView1.TabIndex = 0;
            // 
            // BackButton21
            // 
            this.BackButton21.ActiveBorderThickness = 1;
            this.BackButton21.ActiveCornerRadius = 20;
            this.BackButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BackButton21.ActiveForecolor = System.Drawing.Color.White;
            this.BackButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BackButton21.BackColor = System.Drawing.Color.Transparent;
            this.BackButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton21.BackgroundImage")));
            this.BackButton21.ButtonText = "Back";
            this.BackButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.BackButton21.IdleBorderThickness = 1;
            this.BackButton21.IdleCornerRadius = 20;
            this.BackButton21.IdleFillColor = System.Drawing.Color.White;
            this.BackButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BackButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BackButton21.Location = new System.Drawing.Point(163, 306);
            this.BackButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BackButton21.Name = "BackButton21";
            this.BackButton21.Size = new System.Drawing.Size(135, 42);
            this.BackButton21.TabIndex = 1;
            this.BackButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackButton21.Click += new System.EventHandler(this.BackButton21_Click);
            // 
            // LogOutButton22
            // 
            this.LogOutButton22.ActiveBorderThickness = 1;
            this.LogOutButton22.ActiveCornerRadius = 20;
            this.LogOutButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.LogOutButton22.ActiveForecolor = System.Drawing.Color.White;
            this.LogOutButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.LogOutButton22.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutButton22.BackgroundImage")));
            this.LogOutButton22.ButtonText = "LogOut";
            this.LogOutButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.LogOutButton22.IdleBorderThickness = 1;
            this.LogOutButton22.IdleCornerRadius = 20;
            this.LogOutButton22.IdleFillColor = System.Drawing.Color.White;
            this.LogOutButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.LogOutButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.LogOutButton22.Location = new System.Drawing.Point(163, 358);
            this.LogOutButton22.Margin = new System.Windows.Forms.Padding(5);
            this.LogOutButton22.Name = "LogOutButton22";
            this.LogOutButton22.Size = new System.Drawing.Size(135, 42);
            this.LogOutButton22.TabIndex = 2;
            this.LogOutButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutButton22.Click += new System.EventHandler(this.LogOutButton22_Click);
            // 
            // StudentShowAllCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 412);
            this.Controls.Add(this.LogOutButton22);
            this.Controls.Add(this.BackButton21);
            this.Controls.Add(this.CoursedataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentShowAllCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentShowAllCourse";
            this.Load += new System.EventHandler(this.StudentShowAllCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CoursedataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 BackButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 LogOutButton22;
    }
}