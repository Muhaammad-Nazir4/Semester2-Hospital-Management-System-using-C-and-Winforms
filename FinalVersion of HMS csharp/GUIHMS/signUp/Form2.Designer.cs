
namespace signUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.EyeButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.UsernameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BackToSignUpButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.EyeButton);
            this.panel2.Controls.Add(this.PasswordLabel);
            this.panel2.Controls.Add(this.ApplicationLabel);
            this.panel2.Controls.Add(this.LoginLabel);
            this.panel2.Controls.Add(this.UsernameLabel);
            this.panel2.Controls.Add(this.PasswordTextBox1);
            this.panel2.Controls.Add(this.UsernameTextBox);
            this.panel2.Location = new System.Drawing.Point(284, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 509);
            this.panel2.TabIndex = 117;
            // 
            // EyeButton
            // 
            this.EyeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EyeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeButton.BackgroundImage")));
            this.EyeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EyeButton.Location = new System.Drawing.Point(459, 222);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(24, 21);
            this.EyeButton.TabIndex = 59;
            this.EyeButton.UseVisualStyleBackColor = false;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(32, 215);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 27);
            this.PasswordLabel.TabIndex = 33;
            this.PasswordLabel.Text = "Password";
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ApplicationLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApplicationLabel.Location = new System.Drawing.Point(61, 63);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(398, 37);
            this.ApplicationLabel.TabIndex = 32;
            this.ApplicationLabel.Text = "Hospital Management System";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Location = new System.Drawing.Point(179, 121);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(128, 26);
            this.LoginLabel.TabIndex = 29;
            this.LoginLabel.Text = "Login Page";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLabel.Location = new System.Drawing.Point(32, 167);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(108, 27);
            this.UsernameLabel.TabIndex = 28;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.Location = new System.Drawing.Point(158, 222);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.PasswordChar = '*';
            this.PasswordTextBox1.Size = new System.Drawing.Size(325, 20);
            this.PasswordTextBox1.TabIndex = 27;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(158, 167);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(325, 20);
            this.UsernameTextBox.TabIndex = 26;
            // 
            // BackToSignUpButton
            // 
            this.BackToSignUpButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackToSignUpButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToSignUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackToSignUpButton.Location = new System.Drawing.Point(25, 459);
            this.BackToSignUpButton.Name = "BackToSignUpButton";
            this.BackToSignUpButton.Size = new System.Drawing.Size(219, 39);
            this.BackToSignUpButton.TabIndex = 31;
            this.BackToSignUpButton.Text = "Back to SignUp Page";
            this.BackToSignUpButton.UseVisualStyleBackColor = false;
            this.BackToSignUpButton.Click += new System.EventHandler(this.BackToSignUpButton_Click_1);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(64, 414);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(134, 39);
            this.LoginButton.TabIndex = 30;
            this.LoginButton.Text = "Login \r\n";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BackToSignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.Button BackToSignUpButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox1;
        private System.Windows.Forms.MaskedTextBox UsernameTextBox;
        private System.Windows.Forms.Button EyeButton;
    }
}