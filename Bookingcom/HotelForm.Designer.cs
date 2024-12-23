namespace Bookingcom
{
    partial class HotelForm
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
            this.HotelPanel = new System.Windows.Forms.Panel();
            this.TelLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HotelDescriptionTB = new System.Windows.Forms.TextBox();
            this.HotelLabel = new System.Windows.Forms.Label();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.RoomsPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.TelTextBox = new System.Windows.Forms.TextBox();
            this.HotelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelPanel
            // 
            this.HotelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HotelPanel.Controls.Add(this.TelTextBox);
            this.HotelPanel.Controls.Add(this.AdresTextBox);
            this.HotelPanel.Controls.Add(this.SaveButton);
            this.HotelPanel.Controls.Add(this.TelLabel);
            this.HotelPanel.Controls.Add(this.label4);
            this.HotelPanel.Controls.Add(this.AdresLabel);
            this.HotelPanel.Controls.Add(this.label2);
            this.HotelPanel.Controls.Add(this.HotelDescriptionTB);
            this.HotelPanel.Controls.Add(this.HotelLabel);
            this.HotelPanel.Controls.Add(this.HotelPictureBox);
            this.HotelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HotelPanel.Location = new System.Drawing.Point(0, 0);
            this.HotelPanel.Name = "HotelPanel";
            this.HotelPanel.Size = new System.Drawing.Size(1094, 320);
            this.HotelPanel.TabIndex = 0;
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(496, 89);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(30, 22);
            this.TelLabel.TabIndex = 7;
            this.TelLabel.Text = "    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тел.:";
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Location = new System.Drawing.Point(496, 57);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(30, 22);
            this.AdresLabel.TabIndex = 5;
            this.AdresLabel.Text = "    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес:";
            // 
            // HotelDescriptionTB
            // 
            this.HotelDescriptionTB.Enabled = false;
            this.HotelDescriptionTB.Location = new System.Drawing.Point(428, 114);
            this.HotelDescriptionTB.Multiline = true;
            this.HotelDescriptionTB.Name = "HotelDescriptionTB";
            this.HotelDescriptionTB.ReadOnly = true;
            this.HotelDescriptionTB.Size = new System.Drawing.Size(625, 155);
            this.HotelDescriptionTB.TabIndex = 2;
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.Location = new System.Drawing.Point(16, 272);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(58, 22);
            this.HotelLabel.TabIndex = 1;
            this.HotelLabel.Text = "label1";
            // 
            // HotelPictureBox
            // 
            this.HotelPictureBox.Location = new System.Drawing.Point(20, 17);
            this.HotelPictureBox.Name = "HotelPictureBox";
            this.HotelPictureBox.Size = new System.Drawing.Size(366, 252);
            this.HotelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HotelPictureBox.TabIndex = 0;
            this.HotelPictureBox.TabStop = false;
            // 
            // RoomsPanel
            // 
            this.RoomsPanel.BackColor = System.Drawing.Color.White;
            this.RoomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomsPanel.Location = new System.Drawing.Point(0, 320);
            this.RoomsPanel.Name = "RoomsPanel";
            this.RoomsPanel.Size = new System.Drawing.Size(1094, 335);
            this.RoomsPanel.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(917, 275);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(136, 36);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdresTextBox.Location = new System.Drawing.Point(500, 57);
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(553, 25);
            this.AdresTextBox.TabIndex = 9;
            // 
            // TelTextBox
            // 
            this.TelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelTextBox.Location = new System.Drawing.Point(500, 86);
            this.TelTextBox.Name = "TelTextBox";
            this.TelTextBox.Size = new System.Drawing.Size(553, 25);
            this.TelTextBox.TabIndex = 10;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 655);
            this.Controls.Add(this.RoomsPanel);
            this.Controls.Add(this.HotelPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HotelForm";
            this.HotelPanel.ResumeLayout(false);
            this.HotelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HotelPanel;
        private System.Windows.Forms.Label HotelLabel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Panel RoomsPanel;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AdresLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HotelDescriptionTB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TelTextBox;
        private System.Windows.Forms.TextBox AdresTextBox;
    }
}