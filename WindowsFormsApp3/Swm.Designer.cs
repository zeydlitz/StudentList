namespace WindowsFormsApp3
{
    partial class Swm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Univer = new System.Windows.Forms.Label();
            this.University = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Home_address = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.un_address = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(371, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "FirstName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(200, 35);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Input";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(200, 81);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthdate";
            // 
            // BD
            // 
            this.BD.Location = new System.Drawing.Point(200, 122);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(100, 20);
            this.BD.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passport";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(200, 162);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(100, 20);
            this.Pass.TabIndex = 8;
            // 
            // Univer
            // 
            this.Univer.AutoSize = true;
            this.Univer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Univer.Location = new System.Drawing.Point(26, 257);
            this.Univer.Name = "Univer";
            this.Univer.Size = new System.Drawing.Size(85, 21);
            this.Univer.TabIndex = 9;
            this.Univer.Text = "University";
            // 
            // University
            // 
            this.University.Location = new System.Drawing.Point(200, 257);
            this.University.Name = "University";
            this.University.Size = new System.Drawing.Size(100, 20);
            this.University.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // Home_address
            // 
            this.Home_address.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Home_address.Location = new System.Drawing.Point(200, 202);
            this.Home_address.Name = "Home_address";
            this.Home_address.Size = new System.Drawing.Size(100, 30);
            this.Home_address.TabIndex = 13;
            this.Home_address.Text = "Adress";
            this.Home_address.UseVisualStyleBackColor = true;
            this.Home_address.Click += new System.EventHandler(this.Adress_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "University address";
            // 
            // un_address
            // 
            this.un_address.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.un_address.Location = new System.Drawing.Point(200, 292);
            this.un_address.Name = "un_address";
            this.un_address.Size = new System.Drawing.Size(100, 30);
            this.un_address.TabIndex = 16;
            this.un_address.Text = "Adress";
            this.un_address.UseVisualStyleBackColor = true;
            this.un_address.Click += new System.EventHandler(this.un_address_Click);
            // 
            // Swm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 420);
            this.Controls.Add(this.un_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Home_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.University);
            this.Controls.Add(this.Univer);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Swm";
            this.Text = "New Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Swm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label Univer;
        private System.Windows.Forms.TextBox University;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Home_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button un_address;
    }
}

