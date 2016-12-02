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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NewServiceDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TempServiceDate = new System.Windows.Forms.DateTimePicker();
            this.TempServiceTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10:00 AM",
            "4:00 PM",
            "6:00 PM"});
            this.comboBox1.Location = new System.Drawing.Point(153, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NewServiceDate
            // 
            this.NewServiceDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.NewServiceDate.Location = new System.Drawing.Point(153, 14);
            this.NewServiceDate.Name = "NewServiceDate";
            this.NewServiceDate.Size = new System.Drawing.Size(180, 20);
            this.NewServiceDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "*New Service Date:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "*New Service Time:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "*Template Service Time:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Template Service Date:";
            // 
            // TempServiceDate
            // 
            this.TempServiceDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.TempServiceDate.Location = new System.Drawing.Point(153, 73);
            this.TempServiceDate.Name = "TempServiceDate";
            this.TempServiceDate.Size = new System.Drawing.Size(180, 20);
            this.TempServiceDate.TabIndex = 7;
            // 
            // TempServiceTime
            // 
            this.TempServiceTime.FormattingEnabled = true;
            this.TempServiceTime.Items.AddRange(new object[] {
            "10:00 AM",
            "4:00 PM",
            "6:00 PM"});
            this.TempServiceTime.Location = new System.Drawing.Point(153, 99);
            this.TempServiceTime.Name = "TempServiceTime";
            this.TempServiceTime.Size = new System.Drawing.Size(84, 21);
            this.TempServiceTime.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TempServiceDate);
            this.Controls.Add(this.TempServiceTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewServiceDate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker NewServiceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TempServiceDate;
        private System.Windows.Forms.ComboBox TempServiceTime;
    }
}

