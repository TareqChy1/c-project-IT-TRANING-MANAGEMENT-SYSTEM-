namespace ITDbConnection
{
    partial class ShowAllCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllCourse));
            this.CoursedataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ExitButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursedataGridView1
            // 
            this.CoursedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursedataGridView1.Location = new System.Drawing.Point(1, 31);
            this.CoursedataGridView1.Name = "CoursedataGridView1";
            this.CoursedataGridView1.Size = new System.Drawing.Size(440, 220);
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
            this.BackButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.BackButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton21.Location = new System.Drawing.Point(32, 322);
            this.BackButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BackButton21.Name = "BackButton21";
            this.BackButton21.Size = new System.Drawing.Size(139, 35);
            this.BackButton21.TabIndex = 1;
            this.BackButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackButton21.Click += new System.EventHandler(this.BackButton21_Click);
            // 
            // ExitButton21
            // 
            this.ExitButton21.ActiveBorderThickness = 1;
            this.ExitButton21.ActiveCornerRadius = 20;
            this.ExitButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ExitButton21.ActiveForecolor = System.Drawing.Color.White;
            this.ExitButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ExitButton21.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton21.BackgroundImage")));
            this.ExitButton21.ButtonText = "Exit";
            this.ExitButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.ExitButton21.IdleBorderThickness = 1;
            this.ExitButton21.IdleCornerRadius = 20;
            this.ExitButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.ExitButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ExitButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ExitButton21.Location = new System.Drawing.Point(269, 370);
            this.ExitButton21.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton21.Name = "ExitButton21";
            this.ExitButton21.Size = new System.Drawing.Size(139, 41);
            this.ExitButton21.TabIndex = 3;
            this.ExitButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton21.Click += new System.EventHandler(this.ExitButton21_Click);
            // 
            // ShowAllCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 422);
            this.Controls.Add(this.ExitButton21);
            this.Controls.Add(this.BackButton21);
            this.Controls.Add(this.CoursedataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAllCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAllCourse";
            this.Load += new System.EventHandler(this.ShowAllCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CoursedataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 BackButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 ExitButton21;
    }
}