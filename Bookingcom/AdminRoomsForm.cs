using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bookingcom
{
    public partial class AdminRoomsForm : Form
    {
        public AdminRoomsForm()
        {
            InitializeComponent();
            Text = "Форма управления таблицей \"Номера\"";
        }

        private void AdminRoomsForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);

            List<string> hotels = SQLClass.MySelect("SELECT id, Name FROM hotels");

            HotelsComboBox.Items.Clear();
            for (int i = 0; i < hotels.Count; i += 2)
            {
                HotelsComboBox.Items.Add(hotels[i] + ". " + hotels[i + 1]);
            }

            List<string> rooms = SQLClass.MySelect("SELECT id, name, id_hotel FROM rooms");

            int y = 50;
            for (int i = 0; i < rooms.Count; i += 3)
            {
                Label lbl1 = new Label();
                lbl1.Text = rooms[i];
                lbl1.Location = new Point(20, y);
                lbl1.Size = new Size(50, 30);
                lbl1.Tag = rooms[i];
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Text = rooms[i + 1];
                lbl2.Location = new Point(100, y);
                lbl2.Size = new Size(300, 30);
                panel1.Controls.Add(lbl2);

                List<string> hotel = SQLClass.MySelect("SELECT Name FROM hotels WHERE id = '" + rooms[i + 2] + "'");

                Label lbl3 = new Label();
                lbl3.Text = hotel[0];
                lbl3.Location = new Point(450, y);
                lbl3.Size = new Size(250, 30);
                panel1.Controls.Add(lbl3);

                Button btn = new Button();
                btn.Location = new Point(750, y);
                btn.Size = new Size(100, 30);
                btn.Text = "Удалить";
                btn.Click += new EventHandler(DelRoomClick);
                panel1.Controls.Add(btn);

                y += 40;
            }
        }

        string adress;
        private void AddPicRoomBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                PicRoomPictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            if(NameRoomTextBox.Text != "" && HotelsComboBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO rooms (name, id_hotel, image) VALUES ('" + NameRoomTextBox.Text + "','" + HotelsComboBox.Text + "','" + adress + "' )");
                MessageBox.Show("Сохранено");
                NameRoomTextBox.Text = "";
                HotelsComboBox.Text = "";
                PicRoomPictureBox.Image = null;
                AdminRoomsForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Заполните обязательный поля");
            }
        }

        private void DelRoomClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(20, y))
                {
                    SQLClass.MyUpDate("DELETE FROM rooms WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Успешно удалено");
                }
            }
            AdminRoomsForm_Load(sender, e);
        }

    }
}
