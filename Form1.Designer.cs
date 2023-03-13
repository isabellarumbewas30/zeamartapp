namespace zeamart_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_jewelry = new System.Windows.Forms.DataGridView();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_kode = new System.Windows.Forms.TextBox();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.tb_desk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_jewelry)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_jewelry
            // 
            this.data_jewelry.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_jewelry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_jewelry.Location = new System.Drawing.Point(30, 103);
            this.data_jewelry.Name = "data_jewelry";
            this.data_jewelry.RowTemplate.Height = 25;
            this.data_jewelry.Size = new System.Drawing.Size(469, 172);
            this.data_jewelry.TabIndex = 0;
            this.data_jewelry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_jewelry_CellClick);
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(30, 387);
            this.tb_nama.Multiline = true;
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(469, 27);
            this.tb_nama.TabIndex = 1;
            this.tb_nama.TextChanged += new System.EventHandler(this.tb_nama_TextChanged);
            // 
            // tb_kode
            // 
            this.tb_kode.Location = new System.Drawing.Point(30, 456);
            this.tb_kode.Multiline = true;
            this.tb_kode.Name = "tb_kode";
            this.tb_kode.Size = new System.Drawing.Size(469, 27);
            this.tb_kode.TabIndex = 2;
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(30, 511);
            this.tb_harga.Multiline = true;
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(469, 27);
            this.tb_harga.TabIndex = 3;
            // 
            // tb_desk
            // 
            this.tb_desk.Location = new System.Drawing.Point(30, 571);
            this.tb_desk.Multiline = true;
            this.tb_desk.Name = "tb_desk";
            this.tb_desk.Size = new System.Drawing.Size(469, 87);
            this.tb_desk.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Deskripsi";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(156)))), ((int)(((byte)(115)))));
            this.btn_add.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(30, 674);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 34);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Save";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(156)))), ((int)(((byte)(115)))));
            this.btn_edit.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.Location = new System.Drawing.Point(224, 674);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 34);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Isabel Jewelry by ZeaMart";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(93)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 49);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cari Data";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(109, 61);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(390, 34);
            this.tb_search.TabIndex = 17;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(156)))), ((int)(((byte)(115)))));
            this.btn_delete.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(409, 674);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 34);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(30, 324);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(469, 27);
            this.tb_id.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(34, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 27);
            this.label11.TabIndex = 30;
            this.label11.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(218)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(679, 721);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_desk);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.tb_kode);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.data_jewelry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_jewelry)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView data_jewelry;
        private TextBox tb_nama;
        private TextBox tb_kode;
        private TextBox tb_harga;
        private TextBox tb_desk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private Button btn_edit;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private TextBox tb_search;
        private Button btn_delete;
        private TextBox tb_id;
        private Label label11;
    }
}