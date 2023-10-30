namespace Lab6._2_SamuelCamirand
{
    partial class FormRegex
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChkEmail = new System.Windows.Forms.Button();
            this.btnDelExSpaces = new System.Windows.Forms.Button();
            this.btnValPostalCode = new System.Windows.Forms.Button();
            this.btnDelLetters = new System.Windows.Forms.Button();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the text to validate :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Province:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postal Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telephone:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(79, 102);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(227, 20);
            this.txtUser.TabIndex = 7;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(79, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 20);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(79, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(227, 20);
            this.txtCity.TabIndex = 9;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(79, 180);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(227, 20);
            this.txtProv.TabIndex = 10;
            this.txtProv.TextChanged += new System.EventHandler(this.txtProv_TextChanged);
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(79, 206);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(227, 20);
            this.txtPC.TabIndex = 11;
            this.txtPC.TextChanged += new System.EventHandler(this.txtPC_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(79, 232);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(227, 20);
            this.txtTel.TabIndex = 12;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(312, 102);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(75, 150);
            this.btnValid.TabIndex = 13;
            this.btnValid.Text = "&Validate\r\nUser Name\r\nAddress\r\nCity\r\nProvince\r\nPostal Code\r\nTelephone";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(393, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChkEmail
            // 
            this.btnChkEmail.Location = new System.Drawing.Point(15, 56);
            this.btnChkEmail.Name = "btnChkEmail";
            this.btnChkEmail.Size = new System.Drawing.Size(49, 37);
            this.btnChkEmail.TabIndex = 15;
            this.btnChkEmail.Text = "Check\r\nE-mail";
            this.btnChkEmail.UseVisualStyleBackColor = true;
            this.btnChkEmail.Click += new System.EventHandler(this.btnChkEmail_Click);
            // 
            // btnDelExSpaces
            // 
            this.btnDelExSpaces.Location = new System.Drawing.Point(70, 56);
            this.btnDelExSpaces.Name = "btnDelExSpaces";
            this.btnDelExSpaces.Size = new System.Drawing.Size(77, 37);
            this.btnDelExSpaces.TabIndex = 16;
            this.btnDelExSpaces.Text = "Delete Extra\r\n&Spaces";
            this.btnDelExSpaces.UseVisualStyleBackColor = true;
            this.btnDelExSpaces.Click += new System.EventHandler(this.btnDelExSpaces_Click);
            // 
            // btnValPostalCode
            // 
            this.btnValPostalCode.Location = new System.Drawing.Point(153, 56);
            this.btnValPostalCode.Name = "btnValPostalCode";
            this.btnValPostalCode.Size = new System.Drawing.Size(77, 37);
            this.btnValPostalCode.TabIndex = 17;
            this.btnValPostalCode.Text = "Validate\r\n&Postal Code";
            this.btnValPostalCode.UseVisualStyleBackColor = true;
            this.btnValPostalCode.Click += new System.EventHandler(this.btnValPostalCode_Click);
            // 
            // btnDelLetters
            // 
            this.btnDelLetters.Location = new System.Drawing.Point(236, 56);
            this.btnDelLetters.Name = "btnDelLetters";
            this.btnDelLetters.Size = new System.Drawing.Size(83, 37);
            this.btnDelLetters.TabIndex = 18;
            this.btnDelLetters.Text = "Delete &Letters\r\na,b,c and d";
            this.btnDelLetters.UseVisualStyleBackColor = true;
            this.btnDelLetters.Click += new System.EventHandler(this.btnDelLetters_Click);
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(325, 56);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(72, 37);
            this.btnCreateArray.TabIndex = 19;
            this.btnCreateArray.Text = "Create ab \r\n&Array of\r\nWords";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 257);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.btnDelLetters);
            this.Controls.Add(this.btnValPostalCode);
            this.Controls.Add(this.btnDelExSpaces);
            this.Controls.Add(this.btnChkEmail);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPC);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegex";
            this.Text = "Form Regex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChkEmail;
        private System.Windows.Forms.Button btnDelExSpaces;
        private System.Windows.Forms.Button btnValPostalCode;
        private System.Windows.Forms.Button btnDelLetters;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.TextBox textBox1;
    }
}

