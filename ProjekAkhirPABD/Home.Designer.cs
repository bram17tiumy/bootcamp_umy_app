namespace ProjekAkhirPABD
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.dView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataKosanTablePenghuniDataSet = new ProjekAkhirPABD.DataKosanTablePenghuniDataSet();
            this.dataKosanTablePenghuniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataKosanTablePenghuniDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.penghunikoskosanTableAdapter1 = new ProjekAkhirPABD.DataKosanTablePenghuniDataSetTableAdapters.penghunikoskosanTableAdapter();
            this.btkeloladata = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKosanTablePenghuniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKosanTablePenghuniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKosanTablePenghuniDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "test... ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dView
            // 
            this.dView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dView.Location = new System.Drawing.Point(0, 143);
            this.dView.Name = "dView";
            this.dView.RowTemplate.Height = 24;
            this.dView.Size = new System.Drawing.Size(1241, 316);
            this.dView.TabIndex = 2;
            this.dView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(541, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Penghuni Kost Putra Ash Shaaff";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(657, 101);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(584, 36);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(542, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cari : ";
            // 
            // dataKosanTablePenghuniDataSet
            // 
            this.dataKosanTablePenghuniDataSet.DataSetName = "DataKosanTablePenghuniDataSet";
            this.dataKosanTablePenghuniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataKosanTablePenghuniDataSetBindingSource
            // 
            this.dataKosanTablePenghuniDataSetBindingSource.DataSource = this.dataKosanTablePenghuniDataSet;
            this.dataKosanTablePenghuniDataSetBindingSource.Position = 0;
            // 
            // dataKosanTablePenghuniDataSetBindingSource1
            // 
            this.dataKosanTablePenghuniDataSetBindingSource1.DataSource = this.dataKosanTablePenghuniDataSet;
            this.dataKosanTablePenghuniDataSetBindingSource1.Position = 0;
            // 
            // penghunikoskosanTableAdapter1
            // 
            this.penghunikoskosanTableAdapter1.ClearBeforeFill = true;
            // 
            // btkeloladata
            // 
            this.btkeloladata.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkeloladata.Location = new System.Drawing.Point(20, 64);
            this.btkeloladata.Name = "btkeloladata";
            this.btkeloladata.Size = new System.Drawing.Size(215, 73);
            this.btkeloladata.TabIndex = 7;
            this.btkeloladata.Text = "Kelola Data";
            this.btkeloladata.UseVisualStyleBackColor = true;
            this.btkeloladata.Click += new System.EventHandler(this.btkeloladata_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(372, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 73);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1261, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btkeloladata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKosanTablePenghuniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKosanTablePenghuniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKosanTablePenghuniDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dataKosanTablePenghuniDataSetBindingSource;
        private DataKosanTablePenghuniDataSet dataKosanTablePenghuniDataSet;
        private System.Windows.Forms.BindingSource dataKosanTablePenghuniDataSetBindingSource1;
        private DataKosanTablePenghuniDataSetTableAdapters.penghunikoskosanTableAdapter penghunikoskosanTableAdapter1;
        private System.Windows.Forms.Button btkeloladata;
        private System.Windows.Forms.Button button1;
    }
}