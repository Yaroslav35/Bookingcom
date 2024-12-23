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
    public partial class HotelForm : Form
    {
        string idHotel;
        public HotelForm(string _idHotel)
        {
            InitializeComponent();

            idHotel = _idHotel;

            SaveButton.Visible = Convert.ToBoolean(MainForm.isAdmin);

            HotelDescriptionTB.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            HotelDescriptionTB.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            AdresTextBox.Visible = Convert.ToBoolean(MainForm.isAdmin);
            TelTextBox.Visible = Convert.ToBoolean(MainForm.isAdmin);


            List<string> hotel = SQLClass.MySelect("SELECT id, name, rating, id_city, image, adress, tel, opis FROM hotels WHERE id = " + idHotel);

            Text = hotel[1];
            HotelPictureBox.Load("../../Pictures/" + hotel[4]);
            HotelLabel.Text = hotel[1];

            int rating = Convert.ToInt32(hotel[2]);
            int x = 450;
            for(int i=0; i<rating; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Load("../../Pictures/star.png");
                pb.Location = new Point(x, 15);
                pb.Size = new Size(48, 42);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                HotelPanel.Controls.Add(pb);

                x += 55;
            }

            AdresLabel.Text = hotel[5];
            TelLabel.Text = hotel[6];
            AdresTextBox.Text = hotel[5];
            TelTextBox.Text = hotel[6];
            HotelDescriptionTB.Text = hotel[7];

            List<string> rooms = SQLClass.MySelect("SELECT id, name, id_hotel, image, kol FROM rooms WHERE id_hotel = " + idHotel);

            int xRooms = 20;
            for (int i = 0; i < rooms.Count; i += 5)
            {
                Label lbl = new Label();
                lbl.Text = rooms[i + 1];
                lbl.Location = new Point(xRooms, 280);
                lbl.Size = new Size(350, 20);
                lbl.Tag = rooms[i];
                lbl.Click += new EventHandler(Roomlabel_Click);
                RoomsPanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Text = "Количество номеров: " + rooms[i + 4];
                lbl1.Location = new Point(xRooms, 300);
                lbl1.Size = new Size(350, 20);
                RoomsPanel.Controls.Add(lbl1);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + rooms[i + 3]);
                }
                catch (Exception) { }
                pb.Location = new Point(xRooms, 30);
                pb.Size = new Size(350, 250);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = rooms[i];
                pb.Click += new EventHandler(RoomPB_Click);
                RoomsPanel.Controls.Add(pb);

                xRooms += 400;
            }

        }

        private void RoomPB_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm roomForm = new RoomForm(pb.Tag.ToString());
            roomForm.ShowDialog();
        }

        private void Roomlabel_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            RoomForm roomForm = new RoomForm(lbl.Tag.ToString());
            roomForm.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE hotels SET opis = '" + HotelDescriptionTB.Text + "', tel = '" + TelTextBox.Text +"', adress = '" + AdresTextBox.Text + "' WHERE id = " + idHotel);
            MessageBox.Show("Сохранено");
        }
    }
}
