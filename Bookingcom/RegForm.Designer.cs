namespace Bookingcom
{
    partial class RegForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasConfirmTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(12, 50);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(346, 27);
            this.NameTB.TabIndex = 1;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(12, 112);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(346, 27);
            this.SurnameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(12, 190);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(346, 27);
            this.LoginTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            // 
            // PasTB
            // 
            this.PasTB.Location = new System.Drawing.Point(12, 248);
            this.PasTB.Name = "PasTB";
            this.PasTB.PasswordChar = '*';
            this.PasTB.Size = new System.Drawing.Size(346, 27);
            this.PasTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль";
            // 
            // PasConfirmTB
            // 
            this.PasConfirmTB.Location = new System.Drawing.Point(12, 310);
            this.PasConfirmTB.Name = "PasConfirmTB";
            this.PasConfirmTB.PasswordChar = '*';
            this.PasConfirmTB.Size = new System.Drawing.Size(346, 27);
            this.PasConfirmTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Подтверждение пароля";
            // 
            // RegBTN
            // 
            this.RegBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RegBTN.Location = new System.Drawing.Point(0, 382);
            this.RegBTN.Name = "RegBTN";
            this.RegBTN.Size = new System.Drawing.Size(370, 34);
            this.RegBTN.TabIndex = 10;
            this.RegBTN.Text = "Зарегистрироваться";
            this.RegBTN.UseVisualStyleBackColor = true;
            this.RegBTN.Click += new System.EventHandler(this.RegBTN_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 416);
            this.Controls.Add(this.RegBTN);
            this.Controls.Add(this.PasConfirmTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрации нового пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasConfirmTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegBTN;
    }
}