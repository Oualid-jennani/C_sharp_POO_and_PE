namespace S7_TP_1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNaiss = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.importXMLBtn = new System.Windows.Forms.Button();
            this.exportXMLBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.exportBinaryBtn = new System.Windows.Forms.Button();
            this.importBinaryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 272);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(726, 234);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.adresse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateNaiss);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations client";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(407, 146);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(180, 26);
            this.phone.TabIndex = 14;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(407, 97);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(181, 26);
            this.email.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(407, 45);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(181, 26);
            this.adresse.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adresse";
            // 
            // dateNaiss
            // 
            this.dateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNaiss.Location = new System.Drawing.Point(155, 141);
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.Size = new System.Drawing.Size(106, 26);
            this.dateNaiss.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date de naissance";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(110, 94);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(136, 26);
            this.firstName.TabIndex = 5;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(110, 48);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(136, 26);
            this.lastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(18, 25);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(89, 38);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtnEvent);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(612, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 253);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.exitEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteBtnEvent);
            // 
            // importXMLBtn
            // 
            this.importXMLBtn.Location = new System.Drawing.Point(11, 19);
            this.importXMLBtn.Name = "importXMLBtn";
            this.importXMLBtn.Size = new System.Drawing.Size(89, 38);
            this.importXMLBtn.TabIndex = 9;
            this.importXMLBtn.Text = "Importer (XML)";
            this.importXMLBtn.UseVisualStyleBackColor = true;
            this.importXMLBtn.Click += new System.EventHandler(this.importXMLEvent);
            // 
            // exportXMLBtn
            // 
            this.exportXMLBtn.Location = new System.Drawing.Point(110, 18);
            this.exportXMLBtn.Name = "exportXMLBtn";
            this.exportXMLBtn.Size = new System.Drawing.Size(89, 38);
            this.exportXMLBtn.TabIndex = 10;
            this.exportXMLBtn.Text = "Exporter (XML)";
            this.exportXMLBtn.UseVisualStyleBackColor = true;
            this.exportXMLBtn.Click += new System.EventHandler(this.exportXMLEvent);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.exportBinaryBtn);
            this.groupBox3.Controls.Add(this.importBinaryBtn);
            this.groupBox3.Controls.Add(this.exportXMLBtn);
            this.groupBox3.Controls.Add(this.importXMLBtn);
            this.groupBox3.Location = new System.Drawing.Point(13, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 64);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import/Export";
            // 
            // exportBinaryBtn
            // 
            this.exportBinaryBtn.Location = new System.Drawing.Point(494, 17);
            this.exportBinaryBtn.Name = "exportBinaryBtn";
            this.exportBinaryBtn.Size = new System.Drawing.Size(89, 38);
            this.exportBinaryBtn.TabIndex = 12;
            this.exportBinaryBtn.Text = "Exporter (Fichier binaire)";
            this.exportBinaryBtn.UseVisualStyleBackColor = true;
            this.exportBinaryBtn.Click += new System.EventHandler(this.exportBinaryEvent);
            // 
            // importBinaryBtn
            // 
            this.importBinaryBtn.Location = new System.Drawing.Point(395, 18);
            this.importBinaryBtn.Name = "importBinaryBtn";
            this.importBinaryBtn.Size = new System.Drawing.Size(89, 38);
            this.importBinaryBtn.TabIndex = 11;
            this.importBinaryBtn.Text = "Importer (Fichier binaire)";
            this.importBinaryBtn.UseVisualStyleBackColor = true;
            this.importBinaryBtn.Click += new System.EventHandler(this.importBinaryEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Gestion des clients";
            this.Load += new System.EventHandler(this.formLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateNaiss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportXMLBtn;
        private System.Windows.Forms.Button importXMLBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button exportBinaryBtn;
        private System.Windows.Forms.Button importBinaryBtn;
        private System.Windows.Forms.Button button2;
    }
}

