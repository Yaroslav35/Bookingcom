using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcom
{
    public partial class AdminUsersForm : Form
    {
        public AdminUsersForm()
        {
            InitializeComponent();
            Text = "Форма управления таблицей \"Пользователи\"";
        }

        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);

            List<string> users = SQLClass.MySelect("SELECT id, login, pass, name, surname FROM users ORDER BY id");

            int y = 45;
            for (int i = 0; i < users.Count; i += 5)
            {
                Label lbl0 = new Label();
                lbl0.Text = users[i];
                lbl0.Location = new Point(10, y);
                lbl0.Size = new Size(50, 30);
                lbl0.Tag = users[i];
                panel1.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Text = users[i + 1];
                lbl1.Location = new Point(80, y);
                lbl1.Size = new Size(100, 30);
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Text = users[i + 2];
                lbl2.Location = new Point(200, y);
                lbl2.Size = new Size(100, 30);
                panel1.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Text = users[i + 3];
                lbl3.Location = new Point(350, y);
                lbl3.Size = new Size(120, 30);
                panel1.Controls.Add(lbl3);

                Label lbl4 = new Label();
                lbl4.Text = users[i + 4];
                lbl4.Location = new Point(500, y);
                lbl4.Size = new Size(100, 30);
                panel1.Controls.Add(lbl4);

                Button button = new Button();
                button.Location = new Point(700, y);
                button.Size = new Size(80, 30);
                button.Text = "Удалить";
                button.Click += new EventHandler(DelUserClick);
                panel1.Controls.Add(button);

                y += 30;
            }
        }


        private void DelUserClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(10, y))
                {
                    SQLClass.MyUpDate("DELETE FROM users WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Успешно удалено");
                }
            }
            AdminUsersForm_Load(sender, e);
        }
    }
}
