namespace FCIS_DIRECTIONS
{
    partial class ModifiyMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifiyMembers));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMembersName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PicAddLoaction = new System.Windows.Forms.PictureBox();
            this.btnInsertmemberLocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInsertmemberName = new System.Windows.Forms.TextBox();
            this.btndeleteMember = new System.Windows.Forms.Button();
            this.btnModifyMember = new System.Windows.Forms.Button();
            this.btnInsertMember = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsaveChanges = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.go_back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAddLoaction)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1241, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "الأسم";
            // 
            // cmbMembersName
            // 
            this.cmbMembersName.FormattingEnabled = true;
            this.cmbMembersName.Location = new System.Drawing.Point(1076, 283);
            this.cmbMembersName.Name = "cmbMembersName";
            this.cmbMembersName.Size = new System.Drawing.Size(144, 21);
            this.cmbMembersName.TabIndex = 3;
            this.cmbMembersName.SelectedIndexChanged += new System.EventHandler(this.cmbMembersName_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1076, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(224, 180);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PicAddLoaction
            // 
            this.PicAddLoaction.Image = ((System.Drawing.Image)(resources.GetObject("PicAddLoaction.Image")));
            this.PicAddLoaction.Location = new System.Drawing.Point(36, 296);
            this.PicAddLoaction.Name = "PicAddLoaction";
            this.PicAddLoaction.Size = new System.Drawing.Size(678, 280);
            this.PicAddLoaction.TabIndex = 9;
            this.PicAddLoaction.TabStop = false;
            this.PicAddLoaction.Click += new System.EventHandler(this.PicAddLoaction_Click);
            // 
            // btnInsertmemberLocation
            // 
            this.btnInsertmemberLocation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertmemberLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertmemberLocation.Image")));
            this.btnInsertmemberLocation.Location = new System.Drawing.Point(600, 611);
            this.btnInsertmemberLocation.Name = "btnInsertmemberLocation";
            this.btnInsertmemberLocation.Size = new System.Drawing.Size(114, 40);
            this.btnInsertmemberLocation.TabIndex = 10;
            this.btnInsertmemberLocation.Text = "أضافه صوره";
            this.btnInsertmemberLocation.UseVisualStyleBackColor = true;
            this.btnInsertmemberLocation.Click += new System.EventHandler(this.btnInsertmemberLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(651, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "الأسم";
            // 
            // txtInsertmemberName
            // 
            this.txtInsertmemberName.Location = new System.Drawing.Point(564, 233);
            this.txtInsertmemberName.Name = "txtInsertmemberName";
            this.txtInsertmemberName.Size = new System.Drawing.Size(150, 20);
            this.txtInsertmemberName.TabIndex = 12;
            this.txtInsertmemberName.TextChanged += new System.EventHandler(this.txtInsertmemberName_TextChanged);
            // 
            // btndeleteMember
            // 
            this.btndeleteMember.BackColor = System.Drawing.Color.Gray;
            this.btndeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteMember.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteMember.Image = ((System.Drawing.Image)(resources.GetObject("btndeleteMember.Image")));
            this.btndeleteMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeleteMember.Location = new System.Drawing.Point(781, 461);
            this.btndeleteMember.Name = "btndeleteMember";
            this.btndeleteMember.Size = new System.Drawing.Size(132, 47);
            this.btndeleteMember.TabIndex = 13;
            this.btndeleteMember.Text = "حذف";
            this.btndeleteMember.UseVisualStyleBackColor = false;
            this.btndeleteMember.Click += new System.EventHandler(this.btndeleteMember_Click);
            // 
            // btnModifyMember
            // 
            this.btnModifyMember.BackColor = System.Drawing.Color.Gray;
            this.btnModifyMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyMember.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMember.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMember.Image")));
            this.btnModifyMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyMember.Location = new System.Drawing.Point(781, 421);
            this.btnModifyMember.Name = "btnModifyMember";
            this.btnModifyMember.Size = new System.Drawing.Size(132, 47);
            this.btnModifyMember.TabIndex = 14;
            this.btnModifyMember.Text = "تعديل";
            this.btnModifyMember.UseVisualStyleBackColor = false;
            this.btnModifyMember.Click += new System.EventHandler(this.btnModifyMember_Click);
            // 
            // btnInsertMember
            // 
            this.btnInsertMember.BackColor = System.Drawing.Color.Gray;
            this.btnInsertMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertMember.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertMember.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertMember.Image")));
            this.btnInsertMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertMember.Location = new System.Drawing.Point(781, 383);
            this.btnInsertMember.Name = "btnInsertMember";
            this.btnInsertMember.Size = new System.Drawing.Size(132, 47);
            this.btnInsertMember.TabIndex = 15;
            this.btnInsertMember.Text = "أضافه";
            this.btnInsertMember.UseVisualStyleBackColor = false;
            this.btnInsertMember.Click += new System.EventHandler(this.btnInsertMember_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(781, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 45);
            this.button3.TabIndex = 60;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsaveChanges
            // 
            this.btnsaveChanges.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveChanges.Image")));
            this.btnsaveChanges.Location = new System.Drawing.Point(1158, 550);
            this.btnsaveChanges.Name = "btnsaveChanges";
            this.btnsaveChanges.Size = new System.Drawing.Size(126, 61);
            this.btnsaveChanges.TabIndex = 61;
            this.btnsaveChanges.Text = "Save Changes";
            this.btnsaveChanges.UseVisualStyleBackColor = true;
            this.btnsaveChanges.Click += new System.EventHandler(this.btnsaveChanges_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.go_back);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 67);
            this.panel1.TabIndex = 65;
            // 
            // go_back
            // 
            this.go_back.FlatAppearance.BorderSize = 0;
            this.go_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go_back.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back.ForeColor = System.Drawing.Color.Transparent;
            this.go_back.Image = ((System.Drawing.Image)(resources.GetObject("go_back.Image")));
            this.go_back.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.go_back.Location = new System.Drawing.Point(1003, 1);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(176, 64);
            this.go_back.TabIndex = 20;
            this.go_back.Text = "Go Back";
            this.go_back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.go_back.UseVisualStyleBackColor = true;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(-2, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(358, 64);
            this.button4.TabIndex = 19;
            this.button4.Text = "Members Directons";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1185, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 52);
            this.button5.TabIndex = 60;
            this.button5.Text = "LOGOUT";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(858, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 66;
            this.label1.Text = "admin names";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(852, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 67;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(333, 596);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(224, 180);
            this.dataGridView2.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(766, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 69;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ModifiyMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsaveChanges);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInsertMember);
            this.Controls.Add(this.btnModifyMember);
            this.Controls.Add(this.btndeleteMember);
            this.Controls.Add(this.txtInsertmemberName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertmemberLocation);
            this.Controls.Add(this.PicAddLoaction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMembersName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifiyMembers";
            this.Text = "ModifiyMembers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifiyMembers_FormClosed);
            this.Load += new System.EventHandler(this.ModifiyMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAddLoaction)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMembersName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox PicAddLoaction;
        private System.Windows.Forms.Button btnInsertmemberLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInsertmemberName;
        private System.Windows.Forms.Button btndeleteMember;
        private System.Windows.Forms.Button btnModifyMember;
        private System.Windows.Forms.Button btnInsertMember;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnsaveChanges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button go_back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}