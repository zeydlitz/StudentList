namespace WindowsFormsApp3
{
    partial class Adress
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.Locality = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Locality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Street";
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(138, 23);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(100, 20);
            this.Country.TabIndex = 5;
            // 
            // Locality
            // 
            this.Locality.Location = new System.Drawing.Point(138, 66);
            this.Locality.Name = "Locality";
            this.Locality.Size = new System.Drawing.Size(100, 20);
            this.Locality.TabIndex = 6;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(138, 104);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(100, 20);
            this.Street.TabIndex = 7;
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(358, 95);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(75, 29);
            this.Input.TabIndex = 8;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Adress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 177);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.Locality);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Adress";
            this.Text = "University";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Country;
        public System.Windows.Forms.TextBox Locality;
        public System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Button Input;
    }
}