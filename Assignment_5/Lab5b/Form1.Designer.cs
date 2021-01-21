
namespace Lab5b
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.doctorPictureBox = new System.Windows.Forms.PictureBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.seriesTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.actorTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorIdCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultsLB = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linqRB = new System.Windows.Forms.RadioButton();
            this.sqlRB = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(68, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(243, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.doctorPictureBox);
            this.groupBox1.Controls.Add(this.ageTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.seriesTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.yearTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.actorTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.doctorIdCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Doctor";
            // 
            // firstTB
            // 
            this.firstTB.Location = new System.Drawing.Point(12, 379);
            this.firstTB.Name = "firstTB";
            this.firstTB.ReadOnly = true;
            this.firstTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstTB.Size = new System.Drawing.Size(405, 35);
            this.firstTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "First full episode:";
            // 
            // doctorPictureBox
            // 
            this.doctorPictureBox.Location = new System.Drawing.Point(220, 138);
            this.doctorPictureBox.Name = "doctorPictureBox";
            this.doctorPictureBox.Size = new System.Drawing.Size(197, 216);
            this.doctorPictureBox.TabIndex = 10;
            this.doctorPictureBox.TabStop = false;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(150, 245);
            this.ageTB.Name = "ageTB";
            this.ageTB.ReadOnly = true;
            this.ageTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ageTB.Size = new System.Drawing.Size(64, 35);
            this.ageTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age at start:";
            // 
            // seriesTB
            // 
            this.seriesTB.Location = new System.Drawing.Point(150, 191);
            this.seriesTB.Name = "seriesTB";
            this.seriesTB.ReadOnly = true;
            this.seriesTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.seriesTB.Size = new System.Drawing.Size(64, 35);
            this.seriesTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Series:";
            // 
            // yearTB
            // 
            this.yearTB.Location = new System.Drawing.Point(150, 150);
            this.yearTB.Name = "yearTB";
            this.yearTB.ReadOnly = true;
            this.yearTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yearTB.Size = new System.Drawing.Size(64, 35);
            this.yearTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year:";
            // 
            // actorTB
            // 
            this.actorTB.Location = new System.Drawing.Point(150, 97);
            this.actorTB.Name = "actorTB";
            this.actorTB.ReadOnly = true;
            this.actorTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.actorTB.Size = new System.Drawing.Size(267, 35);
            this.actorTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Played by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor:";
            // 
            // doctorIdCB
            // 
            this.doctorIdCB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.doctorIdCB.FormattingEnabled = true;
            this.doctorIdCB.Location = new System.Drawing.Point(150, 44);
            this.doctorIdCB.Name = "doctorIdCB";
            this.doctorIdCB.Size = new System.Drawing.Size(267, 37);
            this.doctorIdCB.TabIndex = 0;
            this.doctorIdCB.Text = "1";
            this.doctorIdCB.SelectedIndexChanged += new System.EventHandler(this.doctorIdCB_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultsLB);
            this.groupBox2.Location = new System.Drawing.Point(462, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 420);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Companions and their first episode with this Doctor:";
            // 
            // resultsLB
            // 
            this.resultsLB.FormattingEnabled = true;
            this.resultsLB.ItemHeight = 29;
            this.resultsLB.Location = new System.Drawing.Point(6, 59);
            this.resultsLB.Name = "resultsLB";
            this.resultsLB.Size = new System.Drawing.Size(393, 352);
            this.resultsLB.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab5b.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(887, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 181);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linqRB);
            this.groupBox3.Controls.Add(this.sqlRB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(887, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 117);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Query";
            // 
            // linqRB
            // 
            this.linqRB.AutoSize = true;
            this.linqRB.Checked = true;
            this.linqRB.Location = new System.Drawing.Point(17, 83);
            this.linqRB.Name = "linqRB";
            this.linqRB.Size = new System.Drawing.Size(193, 29);
            this.linqRB.TabIndex = 1;
            this.linqRB.TabStop = true;
            this.linqRB.Text = "Solve Using LINQ";
            this.linqRB.UseVisualStyleBackColor = true;
            // 
            // sqlRB
            // 
            this.sqlRB.AutoSize = true;
            this.sqlRB.Location = new System.Drawing.Point(17, 34);
            this.sqlRB.Name = "sqlRB";
            this.sqlRB.Size = new System.Drawing.Size(193, 29);
            this.sqlRB.TabIndex = 0;
            this.sqlRB.Text = "Solve Using SQL ";
            this.sqlRB.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1116, 32);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLB
            // 
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(36, 25);
            this.statusLB.Text = "OK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1116, 514);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Doctor and Companions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox actorTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctorIdCB;
        private System.Windows.Forms.TextBox firstTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox doctorPictureBox;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox seriesTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox resultsLB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton linqRB;
        private System.Windows.Forms.RadioButton sqlRB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLB;
    }
}

