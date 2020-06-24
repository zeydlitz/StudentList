namespace WindowsFormsApp3
{
    partial class database
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test_dbDataSet = new WindowsFormsApp3.test_dbDataSet();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTableAdapter = new WindowsFormsApp3.test_dbDataSetTableAdapters.addressTableAdapter();
            this.aDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new WindowsFormsApp3.test_dbDataSetTableAdapters.studentTableAdapter();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unadidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDIDDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.addressBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(547, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(182, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bdDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.univerDataGridViewTextBoxColumn,
            this.adidDataGridViewTextBoxColumn1,
            this.unadidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // test_dbDataSet
            // 
            this.test_dbDataSet.DataSetName = "test_dbDataSet";
            this.test_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.test_dbDataSet;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // aDIDDataGridViewTextBoxColumn
            // 
            this.aDIDDataGridViewTextBoxColumn.DataPropertyName = "AD_ID";
            this.aDIDDataGridViewTextBoxColumn.HeaderText = "AD_ID";
            this.aDIDDataGridViewTextBoxColumn.Name = "aDIDDataGridViewTextBoxColumn";
            this.aDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.test_dbDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdDataGridViewTextBoxColumn
            // 
            this.bdDataGridViewTextBoxColumn.DataPropertyName = "bd";
            this.bdDataGridViewTextBoxColumn.HeaderText = "bd";
            this.bdDataGridViewTextBoxColumn.Name = "bdDataGridViewTextBoxColumn";
            this.bdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // univerDataGridViewTextBoxColumn
            // 
            this.univerDataGridViewTextBoxColumn.DataPropertyName = "univer";
            this.univerDataGridViewTextBoxColumn.HeaderText = "univer";
            this.univerDataGridViewTextBoxColumn.Name = "univerDataGridViewTextBoxColumn";
            this.univerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adidDataGridViewTextBoxColumn1
            // 
            this.adidDataGridViewTextBoxColumn1.DataPropertyName = "ad_id";
            this.adidDataGridViewTextBoxColumn1.HeaderText = "ad_id";
            this.adidDataGridViewTextBoxColumn1.Name = "adidDataGridViewTextBoxColumn1";
            this.adidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.adidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // unadidDataGridViewTextBoxColumn
            // 
            this.unadidDataGridViewTextBoxColumn.DataPropertyName = "un_ad_id";
            this.unadidDataGridViewTextBoxColumn.HeaderText = "un_ad_id";
            this.unadidDataGridViewTextBoxColumn.Name = "unadidDataGridViewTextBoxColumn";
            this.unadidDataGridViewTextBoxColumn.ReadOnly = true;
            this.unadidDataGridViewTextBoxColumn.Visible = false;
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(222, 428);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(75, 29);
            this.Input.TabIndex = 10;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 463);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "database";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private test_dbDataSet test_dbDataSet;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private test_dbDataSetTableAdapters.addressTableAdapter addressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private test_dbDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn univerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unadidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Input;
    }
}