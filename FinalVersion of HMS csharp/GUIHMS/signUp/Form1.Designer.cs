
namespace signUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EyeButton = new System.Windows.Forms.Button();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.UsernameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lblnavigation = new System.Windows.Forms.LinkLabel();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.EyeButton);
            this.panel2.Controls.Add(this.RoleLabel);
            this.panel2.Controls.Add(this.PasswordLabel);
            this.panel2.Controls.Add(this.ApplicationLabel);
            this.panel2.Controls.Add(this.SignUpLabel);
            this.panel2.Controls.Add(this.UsernameLabel);
            this.panel2.Controls.Add(this.PasswordTextBox1);
            this.panel2.Controls.Add(this.UsernameTextBox);
            this.panel2.Location = new System.Drawing.Point(286, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 514);
            this.panel2.TabIndex = 117;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "admin",
            "patient",
            "receptionist"});
            this.comboBox1.Location = new System.Drawing.Point(159, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // EyeButton
            // 
            this.EyeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EyeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeButton.BackgroundImage")));
            this.EyeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EyeButton.Location = new System.Drawing.Point(460, 251);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(24, 21);
            this.EyeButton.TabIndex = 58;
            this.EyeButton.UseVisualStyleBackColor = false;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click_1);
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.RoleLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoleLabel.Location = new System.Drawing.Point(56, 301);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(57, 27);
            this.RoleLabel.TabIndex = 55;
            this.RoleLabel.Text = "Role";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(33, 245);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 27);
            this.PasswordLabel.TabIndex = 54;
            this.PasswordLabel.Text = "Password";
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ApplicationLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApplicationLabel.Location = new System.Drawing.Point(86, 69);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(398, 37);
            this.ApplicationLabel.TabIndex = 53;
            this.ApplicationLabel.Text = "Hospital Management System";
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SignUpLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpLabel.Location = new System.Drawing.Point(195, 127);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(143, 26);
            this.SignUpLabel.TabIndex = 51;
            this.SignUpLabel.Text = "SignUp Page";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLabel.Location = new System.Drawing.Point(33, 197);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(108, 27);
            this.UsernameLabel.TabIndex = 50;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.Location = new System.Drawing.Point(159, 252);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.PasswordChar = '*';
            this.PasswordTextBox1.Size = new System.Drawing.Size(325, 20);
            this.PasswordTextBox1.TabIndex = 49;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(159, 197);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(325, 20);
            this.UsernameTextBox.TabIndex = 48;
            // 
            // lblnavigation
            // 
            this.lblnavigation.AutoSize = true;
            this.lblnavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnavigation.Location = new System.Drawing.Point(51, 416);
            this.lblnavigation.Name = "lblnavigation";
            this.lblnavigation.Size = new System.Drawing.Size(188, 25);
            this.lblnavigation.TabIndex = 56;
            this.lblnavigation.TabStop = true;
            this.lblnavigation.Text = "Go to login Page";
            this.lblnavigation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblnavigation_LinkClicked_1);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SignUpButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpButton.Location = new System.Drawing.Point(71, 455);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(134, 39);
            this.SignUpButton.TabIndex = 52;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblnavigation);
            this.Controls.Add(this.SignUpButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button EyeButton;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox1;
        private System.Windows.Forms.MaskedTextBox UsernameTextBox;
        private System.Windows.Forms.LinkLabel lblnavigation;
        private System.Windows.Forms.Button SignUpButton;
    }
}

