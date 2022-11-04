namespace DataSec_Lab_01
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userFormGB = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.signinButton = new System.Windows.Forms.Button();
            this.signinStatLabel = new System.Windows.Forms.Label();
            this.userFormGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // userFormGB
            // 
            this.userFormGB.Controls.Add(this.passwordLabel);
            this.userFormGB.Controls.Add(this.usernameLabel);
            this.userFormGB.Controls.Add(this.passwordTextBox);
            this.userFormGB.Controls.Add(this.usernameTextBox);
            this.userFormGB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFormGB.Location = new System.Drawing.Point(12, 12);
            this.userFormGB.Name = "userFormGB";
            this.userFormGB.Size = new System.Drawing.Size(280, 93);
            this.userFormGB.TabIndex = 0;
            this.userFormGB.TabStop = false;
            this.userFormGB.Text = "User Authorize";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(10, 49);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(10, 22);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 20);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(89, 49);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(160, 22);
            this.passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(89, 22);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(160, 22);
            this.usernameTextBox.TabIndex = 0;
            // this.usernameTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // signinButton
            // 
            this.signinButton.Location = new System.Drawing.Point(111, 105);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(80, 24);
            this.signinButton.TabIndex = 1;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // signinStatLabel
            // 
            this.signinStatLabel.AutoSize = true;
            this.signinStatLabel.BackColor = System.Drawing.Color.Red;
            this.signinStatLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signinStatLabel.Location = new System.Drawing.Point(206, 108);
            this.signinStatLabel.Name = "signinStatLabel";
            this.signinStatLabel.Size = new System.Drawing.Size(51, 18);
            this.signinStatLabel.TabIndex = 2;
            this.signinStatLabel.Text = " STAT ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 141);
            this.Controls.Add(this.signinStatLabel);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.userFormGB);
            this.Name = "Form1";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.userFormGB.ResumeLayout(false);
            this.userFormGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox userFormGB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Label signinStatLabel;
    }
}

