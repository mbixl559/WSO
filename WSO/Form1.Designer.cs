namespace WSO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.NewServiceTme = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NewServiceDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TempServiceDate = new System.Windows.Forms.DateTimePicker();
            this.TempServiceTime = new System.Windows.Forms.ComboBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ThemeLbl = new System.Windows.Forms.Label();
            this.ServiceThemeTxt = new System.Windows.Forms.TextBox();
            this.SongleaderCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewServiceTme
            // 
            this.NewServiceTme.FormattingEnabled = true;
            this.NewServiceTme.Items.AddRange(new object[] {
            "10:30 AM",
            "4:00 PM",
            "6:00 PM"});
            this.NewServiceTme.Location = new System.Drawing.Point(138, 46);
            this.NewServiceTme.Name = "NewServiceTme";
            this.NewServiceTme.Size = new System.Drawing.Size(84, 21);
            this.NewServiceTme.Sorted = true;
            this.NewServiceTme.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 287);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(370, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NewServiceDate
            // 
            this.NewServiceDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.NewServiceDate.Location = new System.Drawing.Point(138, 20);
            this.NewServiceDate.Name = "NewServiceDate";
            this.NewServiceDate.Size = new System.Drawing.Size(180, 20);
            this.NewServiceDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "*New Service Date:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "*New Service Time:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "*Template Service Time:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Template Service Date:";
            // 
            // TempServiceDate
            // 
            this.TempServiceDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.TempServiceDate.Location = new System.Drawing.Point(138, 73);
            this.TempServiceDate.Name = "TempServiceDate";
            this.TempServiceDate.Size = new System.Drawing.Size(180, 20);
            this.TempServiceDate.TabIndex = 7;
            // 
            // TempServiceTime
            // 
            this.TempServiceTime.FormattingEnabled = true;
            this.TempServiceTime.Items.AddRange(new object[] {
            "10:30 AM",
            "4:00 PM",
            "6:00 PM"});
            this.TempServiceTime.Location = new System.Drawing.Point(138, 99);
            this.TempServiceTime.Name = "TempServiceTime";
            this.TempServiceTime.Size = new System.Drawing.Size(84, 21);
            this.TempServiceTime.Sorted = true;
            this.TempServiceTime.TabIndex = 8;
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(138, 126);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(115, 20);
            this.TitleTxt.TabIndex = 11;
            // 
            // TitleLbl
            // 
            this.TitleLbl.Location = new System.Drawing.Point(6, 130);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(126, 20);
            this.TitleLbl.TabIndex = 12;
            this.TitleLbl.Text = "Service Title:";
            // 
            // ThemeLbl
            // 
            this.ThemeLbl.Location = new System.Drawing.Point(6, 155);
            this.ThemeLbl.Name = "ThemeLbl";
            this.ThemeLbl.Size = new System.Drawing.Size(126, 20);
            this.ThemeLbl.TabIndex = 14;
            this.ThemeLbl.Text = "Service Theme:";
            // 
            // ServiceThemeTxt
            // 
            this.ServiceThemeTxt.Location = new System.Drawing.Point(138, 152);
            this.ServiceThemeTxt.Name = "ServiceThemeTxt";
            this.ServiceThemeTxt.Size = new System.Drawing.Size(115, 20);
            this.ServiceThemeTxt.TabIndex = 13;
            // 
            // SongleaderCombo
            // 
            this.SongleaderCombo.FormattingEnabled = true;
            this.SongleaderCombo.Location = new System.Drawing.Point(138, 178);
            this.SongleaderCombo.Name = "SongleaderCombo";
            this.SongleaderCombo.Size = new System.Drawing.Size(115, 21);
            this.SongleaderCombo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Songleader:";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(248, 249);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(94, 23);
            this.CreateBtn.TabIndex = 17;
            this.CreateBtn.Text = "Create Service";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NewServiceTme);
            this.groupBox1.Controls.Add(this.NewServiceDate);
            this.groupBox1.Controls.Add(this.SongleaderCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ThemeLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ServiceThemeTxt);
            this.groupBox1.Controls.Add(this.TempServiceTime);
            this.groupBox1.Controls.Add(this.TitleLbl);
            this.groupBox1.Controls.Add(this.TempServiceDate);
            this.groupBox1.Controls.Add(this.TitleTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 216);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetFormToolStripMenuItem
            // 
            this.resetFormToolStripMenuItem.Name = "resetFormToolStripMenuItem";
            this.resetFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetFormToolStripMenuItem.Text = "Reset Form";
            this.resetFormToolStripMenuItem.Click += new System.EventHandler(this.resetFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(386, 327);
            this.Name = "Form1";
            this.Text = "Service Order Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox NewServiceTme;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker NewServiceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TempServiceDate;
        private System.Windows.Forms.ComboBox TempServiceTime;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label ThemeLbl;
        private System.Windows.Forms.TextBox ServiceThemeTxt;
        private System.Windows.Forms.ComboBox SongleaderCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFormToolStripMenuItem;
    }
}

