namespace FCIS_DIRECTIONS
{
    partial class Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.btnInsertDepart = new System.Windows.Forms.Button();
            this.btnModifyDepart = new System.Windows.Forms.Button();
            this.btndeleteDepartment = new System.Windows.Forms.Button();
            this.txtInsertDepartName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertdepartLocation = new System.Windows.Forms.Button();
            this.PicAddDepart = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbDepartName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.go_back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicAddDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertDepart
            // 
            this.btnInsertDepart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertDepart.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertDepart.Image")));
            this.btnInsertDepart.Location = new System.Drawing.Point(806, 321);
            this.btnInsertDepart.Name = "btnInsertDepart";
            this.btnInsertDepart.Size = new System.Drawing.Size(114, 57);
            this.btnInsertDepart.TabIndex = 28;
            this.btnInsertDepart.Text = "أضافه";
            this.btnInsertDepart.UseVisualStyleBackColor = true;
            this.btnInsertDepart.Click += new System.EventHandler(this.btnInsertDepart_Click);
            // 
            // btnModifyDepart
            // 
            this.btnModifyDepart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyDepart.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyDepart.Image")));
            this.btnModifyDepart.Location = new System.Drawing.Point(806, 372);
            this.btnModifyDepart.Name = "btnModifyDepart";
            this.btnModifyDepart.Size = new System.Drawing.Size(114, 57);
            this.btnModifyDepart.TabIndex = 27;
            this.btnModifyDepart.Text = "تعديل";
            this.btnModifyDepart.UseVisualStyleBackColor = true;
            this.btnModifyDepart.Click += new System.EventHandler(this.btnModifyDepart_Click);
            // 
            // btndeleteDepartment
            // 
            this.btndeleteDepartment.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btndeleteDepartment.Image")));
            this.btndeleteDepartment.Location = new System.Drawing.Point(806, 423);
            this.btndeleteDepartment.Name = "btndeleteDepartment";
            this.btndeleteDepartment.Size = new System.Drawing.Size(114, 53);
            this.btndeleteDepartment.TabIndex = 26;
            this.btndeleteDepartment.Text = "حذف";
            this.btndeleteDepartment.UseVisualStyleBackColor = true;
            this.btndeleteDepartment.Click += new System.EventHandler(this.btndeleteDepartment_Click);
            // 
            // txtInsertDepartName
            // 
            this.txtInsertDepartName.Location = new System.Drawing.Point(482, 222);
            this.txtInsertDepartName.Name = "txtInsertDepartName";
            this.txtInsertDepartName.Size = new System.Drawing.Size(150, 20);
            this.txtInsertDepartName.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(646, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 35);
            this.label5.TabIndex = 24;
            this.label5.Text = "الأسم";
            // 
            // btnInsertdepartLocation
            // 
            this.btnInsertdepartLocation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertdepartLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertdepartLocation.Image")));
            this.btnInsertdepartLocation.Location = new System.Drawing.Point(620, 578);
            this.btnInsertdepartLocation.Name = "btnInsertdepartLocation";
            this.btnInsertdepartLocation.Size = new System.Drawing.Size(114, 49);
            this.btnInsertdepartLocation.TabIndex = 23;
            this.btnInsertdepartLocation.Text = "أضافه صوره";
            this.btnInsertdepartLocation.UseVisualStyleBackColor = true;
            this.btnInsertdepartLocation.Click += new System.EventHandler(this.btnInsertdepartLocation_Click);
            // 
            // PicAddDepart
            // 
            this.PicAddDepart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicAddDepart.BackgroundImage")));
            this.PicAddDepart.Location = new System.Drawing.Point(22, 279);
            this.PicAddDepart.Name = "PicAddDepart";
            this.PicAddDepart.Size = new System.Drawing.Size(744, 264);
            this.PicAddDepart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAddDepart.TabIndex = 22;
            this.PicAddDepart.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1057, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(224, 223);
            this.dataGridView1.TabIndex = 19;
            // 
            // cmbDepartName
            // 
            this.cmbDepartName.FormattingEnabled = true;
            this.cmbDepartName.Location = new System.Drawing.Point(1057, 231);
            this.cmbDepartName.Name = "cmbDepartName";
            this.cmbDepartName.Size = new System.Drawing.Size(144, 21);
            this.cmbDepartName.TabIndex = 18;
            this.cmbDepartName.SelectedIndexChanged += new System.EventHandler(this.cmbDepartName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1230, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "الأسم";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(806, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 43);
            this.button3.TabIndex = 32;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.panel1.TabIndex = 66;
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
            this.button4.Size = new System.Drawing.Size(417, 64);
            this.button4.TabIndex = 19;
            this.button4.Text = "Departments Directons";
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
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInsertDepart);
            this.Controls.Add(this.btnModifyDepart);
            this.Controls.Add(this.btndeleteDepartment);
            this.Controls.Add(this.txtInsertDepartName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertdepartLocation);
            this.Controls.Add(this.PicAddDepart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbDepartName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Department_FormClosed);
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicAddDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertDepart;
        private System.Windows.Forms.Button btnModifyDepart;
        private System.Windows.Forms.Button btndeleteDepartment;
        private System.Windows.Forms.TextBox txtInsertDepartName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertdepartLocation;
        private System.Windows.Forms.PictureBox PicAddDepart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbDepartName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button go_back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}