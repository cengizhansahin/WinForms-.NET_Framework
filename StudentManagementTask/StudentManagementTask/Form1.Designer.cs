namespace StudentManagementTask
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_lastName = new System.Windows.Forms.TextBox();
            this.text_firstName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSilLecture = new System.Windows.Forms.Button();
            this.btnGuncelleLecture = new System.Windows.Forms.Button();
            this.btnKaydetLecture = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.text_lectureName = new System.Windows.Forms.TextBox();
            this.text_lectureCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(462, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_lastName);
            this.panel1.Controls.Add(this.text_firstName);
            this.panel1.Location = new System.Drawing.Point(523, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 306);
            this.panel1.TabIndex = 1;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbGender.Location = new System.Drawing.Point(12, 166);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 9;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(12, 258);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnGuncelle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(12, 228);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(12, 198);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adı";
            // 
            // text_lastName
            // 
            this.text_lastName.Location = new System.Drawing.Point(12, 75);
            this.text_lastName.Name = "text_lastName";
            this.text_lastName.Size = new System.Drawing.Size(100, 20);
            this.text_lastName.TabIndex = 1;
            // 
            // text_firstName
            // 
            this.text_firstName.Location = new System.Drawing.Point(12, 32);
            this.text_firstName.Name = "text_firstName";
            this.text_firstName.Size = new System.Drawing.Size(100, 20);
            this.text_firstName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sayfa1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sayfa2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sayfa3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(62, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(462, 288);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSilLecture);
            this.panel2.Controls.Add(this.btnGuncelleLecture);
            this.panel2.Controls.Add(this.btnKaydetLecture);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.text_lectureCode);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.text_lectureName);
            this.panel2.Location = new System.Drawing.Point(543, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 306);
            this.panel2.TabIndex = 3;
            // 
            // btnSilLecture
            // 
            this.btnSilLecture.BackColor = System.Drawing.Color.Red;
            this.btnSilLecture.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilLecture.Location = new System.Drawing.Point(12, 208);
            this.btnSilLecture.Name = "btnSilLecture";
            this.btnSilLecture.Size = new System.Drawing.Size(86, 23);
            this.btnSilLecture.TabIndex = 8;
            this.btnSilLecture.Text = "SİL";
            this.btnSilLecture.UseVisualStyleBackColor = false;
            this.btnSilLecture.Click += new System.EventHandler(this.btnSilLecture_Click);
            // 
            // btnGuncelleLecture
            // 
            this.btnGuncelleLecture.BackColor = System.Drawing.Color.Cyan;
            this.btnGuncelleLecture.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelleLecture.Location = new System.Drawing.Point(12, 178);
            this.btnGuncelleLecture.Name = "btnGuncelleLecture";
            this.btnGuncelleLecture.Size = new System.Drawing.Size(86, 23);
            this.btnGuncelleLecture.TabIndex = 7;
            this.btnGuncelleLecture.Text = "GÜNCELLE";
            this.btnGuncelleLecture.UseVisualStyleBackColor = false;
            this.btnGuncelleLecture.Click += new System.EventHandler(this.btnGuncelleLecture_Click);
            // 
            // btnKaydetLecture
            // 
            this.btnKaydetLecture.BackColor = System.Drawing.Color.Lime;
            this.btnKaydetLecture.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydetLecture.Location = new System.Drawing.Point(12, 148);
            this.btnKaydetLecture.Name = "btnKaydetLecture";
            this.btnKaydetLecture.Size = new System.Drawing.Size(86, 23);
            this.btnKaydetLecture.TabIndex = 6;
            this.btnKaydetLecture.Text = "KAYDET";
            this.btnKaydetLecture.UseVisualStyleBackColor = false;
            this.btnKaydetLecture.Click += new System.EventHandler(this.btnKaydetLecture_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ders Adı";
            // 
            // text_lectureName
            // 
            this.text_lectureName.Location = new System.Drawing.Point(12, 80);
            this.text_lectureName.Name = "text_lectureName";
            this.text_lectureName.Size = new System.Drawing.Size(100, 20);
            this.text_lectureName.TabIndex = 0;
            // 
            // text_lectureCode
            // 
            this.text_lectureCode.Location = new System.Drawing.Point(12, 119);
            this.text_lectureCode.Name = "text_lectureCode";
            this.text_lectureCode.Size = new System.Drawing.Size(100, 20);
            this.text_lectureCode.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ders Kodu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_lastName;
        private System.Windows.Forms.TextBox text_firstName;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSilLecture;
        private System.Windows.Forms.Button btnGuncelleLecture;
        private System.Windows.Forms.Button btnKaydetLecture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_lectureName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_lectureCode;
    }
}

