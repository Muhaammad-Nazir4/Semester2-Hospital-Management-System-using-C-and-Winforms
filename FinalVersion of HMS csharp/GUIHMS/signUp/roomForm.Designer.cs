
namespace signUp
{
    partial class roomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.ApplicationLabel);
            this.panel1.Controls.Add(this.roomLabel);
            this.panel1.Controls.Add(this.MenuLabel);
            this.panel1.Location = new System.Drawing.Point(268, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 455);
            this.panel1.TabIndex = 93;
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ApplicationLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApplicationLabel.Location = new System.Drawing.Point(52, 49);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(406, 37);
            this.ApplicationLabel.TabIndex = 94;
            this.ApplicationLabel.Text = "Hospital Management System ";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomLabel.Location = new System.Drawing.Point(103, 143);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(309, 204);
            this.roomLabel.TabIndex = 96;
            this.roomLabel.Text = resources.GetString("roomLabel.Text");
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuLabel.Location = new System.Drawing.Point(168, 97);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(201, 26);
            this.MenuLabel.TabIndex = 95;
            this.MenuLabel.Text = "Room Information";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(55, 387);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(134, 39);
            this.BackButton.TabIndex = 97;
            this.BackButton.Text = " Main Menu";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // roomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel1);
            this.Name = "roomForm";
            this.Text = "roomForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button BackButton;
    }
}