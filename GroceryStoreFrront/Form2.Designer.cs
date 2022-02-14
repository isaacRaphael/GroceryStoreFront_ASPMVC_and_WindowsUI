namespace GroceryStoreFrront
{
    partial class Form2
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
            this.Login_Text = new System.Windows.Forms.Label();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Log_In_Btn = new System.Windows.Forms.Button();
            this.Val_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Text
            // 
            this.Login_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Login_Text.AutoSize = true;
            this.Login_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Text.ForeColor = System.Drawing.SystemColors.Info;
            this.Login_Text.Location = new System.Drawing.Point(210, 29);
            this.Login_Text.Name = "Login_Text";
            this.Login_Text.Size = new System.Drawing.Size(49, 13);
            this.Login_Text.TabIndex = 0;
            this.Login_Text.Text = "LOG IN";
            this.Login_Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(125, 106);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(207, 21);
            this.Username_TextBox.TabIndex = 1;
            this.Username_TextBox.TextChanged += new System.EventHandler(this.Username_TextBox_TextChanged);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_label.Location = new System.Drawing.Point(121, 88);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(65, 14);
            this.Username_label.TabIndex = 2;
            this.Username_label.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(125, 158);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(207, 21);
            this.Password_TextBox.TabIndex = 4;
            // 
            // Log_In_Btn
            // 
            this.Log_In_Btn.BackColor = System.Drawing.Color.Maroon;
            this.Log_In_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Log_In_Btn.FlatAppearance.BorderSize = 0;
            this.Log_In_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_In_Btn.ForeColor = System.Drawing.SystemColors.Info;
            this.Log_In_Btn.Location = new System.Drawing.Point(125, 186);
            this.Log_In_Btn.Name = "Log_In_Btn";
            this.Log_In_Btn.Size = new System.Drawing.Size(76, 25);
            this.Log_In_Btn.TabIndex = 5;
            this.Log_In_Btn.Text = "Log In";
            this.Log_In_Btn.UseVisualStyleBackColor = false;
            this.Log_In_Btn.Click += new System.EventHandler(this.Log_In_Btn_Click);
            // 
            // Val_Text
            // 
            this.Val_Text.AutoSize = true;
            this.Val_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Val_Text.ForeColor = System.Drawing.Color.Red;
            this.Val_Text.Location = new System.Drawing.Point(208, 223);
            this.Val_Text.Name = "Val_Text";
            this.Val_Text.Size = new System.Drawing.Size(0, 17);
            this.Val_Text.TabIndex = 6;
            this.Val_Text.Click += new System.EventHandler(this.Val_Text_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Login_Text);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 66);
            this.panel1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Val_Text);
            this.Controls.Add(this.Log_In_Btn);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Username_TextBox);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Text;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button Log_In_Btn;
        private System.Windows.Forms.Label Val_Text;
        private System.Windows.Forms.Panel panel1;
    }
}