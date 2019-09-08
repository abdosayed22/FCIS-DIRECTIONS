namespace FCIS_DIRECTIONS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goadmin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.showloacation = new System.Windows.Forms.PictureBox();
            this.txtShowname = new System.Windows.Forms.TextBox();
            this.cmbShowmembers = new System.Windows.Forms.ComboBox();
            this.cmbShowMangament = new System.Windows.Forms.ComboBox();
            this.cmbShowhalls = new System.Windows.Forms.ComboBox();
            this.cmbShowDepart = new System.Windows.Forms.ComboBox();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.go_admin = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showloacation)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1033, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "المعامل والمدرجات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1025, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "أعضاء هيئه التدريس";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "الأدارات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "الأقسام";
            // 
            // goadmin
            // 
            this.goadmin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.goadmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goadmin.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goadmin.Location = new System.Drawing.Point(1225, 21);
            this.goadmin.Name = "goadmin";
            this.goadmin.Size = new System.Drawing.Size(115, 43);
            this.goadmin.TabIndex = 5;
            this.goadmin.Text = "لوحه التحكم";
            this.goadmin.UseVisualStyleBackColor = false;
            this.goadmin.Click += new System.EventHandler(this.goadmin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1129, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "الأسم";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // showloacation
            // 
            this.showloacation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.showloacation.Location = new System.Drawing.Point(204, 313);
            this.showloacation.Name = "showloacation";
            this.showloacation.Size = new System.Drawing.Size(983, 283);
            this.showloacation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showloacation.TabIndex = 7;
            this.showloacation.TabStop = false;
            // 
            // txtShowname
            // 
            this.txtShowname.BackColor = System.Drawing.SystemColors.Info;
            this.txtShowname.Location = new System.Drawing.Point(879, 257);
            this.txtShowname.Name = "txtShowname";
            this.txtShowname.Size = new System.Drawing.Size(227, 20);
            this.txtShowname.TabIndex = 8;
            this.txtShowname.TextChanged += new System.EventHandler(this.txtShowname_TextChanged);
            // 
            // cmbShowmembers
            // 
            this.cmbShowmembers.FormattingEnabled = true;
            this.cmbShowmembers.Location = new System.Drawing.Point(875, 120);
            this.cmbShowmembers.Name = "cmbShowmembers";
            this.cmbShowmembers.Size = new System.Drawing.Size(121, 21);
            this.cmbShowmembers.TabIndex = 9;
            this.cmbShowmembers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbShowMangament
            // 
            this.cmbShowMangament.FormattingEnabled = true;
            this.cmbShowMangament.Location = new System.Drawing.Point(444, 120);
            this.cmbShowMangament.Name = "cmbShowMangament";
            this.cmbShowMangament.Size = new System.Drawing.Size(121, 21);
            this.cmbShowMangament.TabIndex = 10;
            this.cmbShowMangament.SelectedIndexChanged += new System.EventHandler(this.cmbShowMangament_SelectedIndexChanged);
            // 
            // cmbShowhalls
            // 
            this.cmbShowhalls.FormattingEnabled = true;
            this.cmbShowhalls.Location = new System.Drawing.Point(875, 173);
            this.cmbShowhalls.Name = "cmbShowhalls";
            this.cmbShowhalls.Size = new System.Drawing.Size(121, 21);
            this.cmbShowhalls.TabIndex = 11;
            this.cmbShowhalls.SelectedIndexChanged += new System.EventHandler(this.cmbShowhalls_SelectedIndexChanged);
            // 
            // cmbShowDepart
            // 
            this.cmbShowDepart.FormattingEnabled = true;
            this.cmbShowDepart.Location = new System.Drawing.Point(444, 173);
            this.cmbShowDepart.Name = "cmbShowDepart";
            this.cmbShowDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbShowDepart.TabIndex = 12;
            this.cmbShowDepart.SelectedIndexChanged += new System.EventHandler(this.cmbShowDepart_SelectedIndexChanged);
            // 
            // btncancle
            // 
            this.btncancle.FlatAppearance.BorderSize = 0;
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.Transparent;
            this.btncancle.Image = ((System.Drawing.Image)(resources.GetObject("btncancle.Image")));
            this.btncancle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancle.Location = new System.Drawing.Point(356, 3);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(162, 64);
            this.btncancle.TabIndex = 13;
            this.btncancle.Text = "Cancle";
            this.btncancle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Transparent;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.Location = new System.Drawing.Point(201, 0);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(142, 67);
            this.btnprint.TabIndex = 14;
            this.btnprint.Text = "print";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(28, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 64);
            this.button1.TabIndex = 15;
            this.button1.Text = "Printt";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(666, -7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 74);
            this.button2.TabIndex = 17;
            this.button2.Text = "Home";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Controls.Add(this.btnprint);
            this.panel2.Controls.Add(this.btncancle);
            this.panel2.Controls.Add(this.button1);
            this.panel2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(204, 652);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 59);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.go_admin);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 64);
            this.panel1.TabIndex = 18;
            // 
            // go_admin
            // 
            this.go_admin.FlatAppearance.BorderSize = 0;
            this.go_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go_admin.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_admin.ForeColor = System.Drawing.Color.Transparent;
            this.go_admin.Image = ((System.Drawing.Image)(resources.GetObject("go_admin.Image")));
            this.go_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_admin.Location = new System.Drawing.Point(1116, -2);
            this.go_admin.Name = "go_admin";
            this.go_admin.Size = new System.Drawing.Size(221, 64);
            this.go_admin.TabIndex = 20;
            this.go_admin.Text = "Control Unit";
            this.go_admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.go_admin.UseVisualStyleBackColor = true;
            this.go_admin.Click += new System.EventHandler(this.go_admin_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(-2, -2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 64);
            this.button4.TabIndex = 19;
            this.button4.Text = "FCIS DIRECTIONS";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(891, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 64);
            this.button3.TabIndex = 19;
            this.button3.Text = "About US";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbShowDepart);
            this.Controls.Add(this.cmbShowhalls);
            this.Controls.Add(this.cmbShowMangament);
            this.Controls.Add(this.cmbShowmembers);
            this.Controls.Add(this.txtShowname);
            this.Controls.Add(this.showloacation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goadmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showloacation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button goadmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox showloacation;
        private System.Windows.Forms.TextBox txtShowname;
        private System.Windows.Forms.ComboBox cmbShowmembers;
        private System.Windows.Forms.ComboBox cmbShowMangament;
        private System.Windows.Forms.ComboBox cmbShowhalls;
        private System.Windows.Forms.ComboBox cmbShowDepart;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button go_admin;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

