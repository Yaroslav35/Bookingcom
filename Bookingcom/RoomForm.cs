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
    public partial class RoomForm : Form
    {
        string idRoom;
        int count_rooms;
        public RoomForm(string _idRoom)
        {
            InitializeComponent();

            idRoom = _idRoom;

            SaveButton.Visible = Convert.ToBoolean(MainForm.isAdmin);

            RoomDescriptionTB.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            RoomDescriptionTB.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            PriceTextBox.Visible = Convert.ToBoolean(MainForm.isAdmin);
            SpaceTextBox.Visible = Convert.ToBoolean(MainForm.isAdmin);

            List<string> room = SQLClass.MySelect("SELECT * FROM rooms WHERE id = " + idRoom);

            Text = room[1];
            RoomPictureBox.Load("../../Pictures/" + room[3]);
            RoomLabel.Text = room[1];
            RoomDescriptionTB.Text = room[6];
            PriceLabel.Text = "Цена, руб. " + room[4];
            SpaceLabel.Text = "Площадь, кв.м. " + room[5];
            PriceTextBox.Text = room[4];
            SpaceTextBox.Text = room[5];
            count_rooms = Convert.ToInt32(room[7]);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE rooms SET opis = '" + RoomDescriptionTB.Text + "', price = '" + PriceTextBox.Text + "', space = '" + SpaceTextBox.Text + "' WHERE id = " + idRoom);
            MessageBox.Show("Сохранено");
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            if(MainForm.Login == "")
            {
                MessageBox.Show("Вы не авторизованы");
                return;
            }

            DateTime dt = IndateTimePicker.Value;
            while(dt <= OutdateTimePicker.Value.AddDays(0.5))
            {
                List<string> exitBooking = SQLClass.MySelect("SELECT COUNT(*) FROM booking WHERE dateFrom <= '" + dt.ToString("yyyy-MM-dd") + "' AND dateTo >= '" + dt.ToString("yyyy-MM-dd") + "' AND room_id = " + idRoom);
                if (Convert.ToInt32(exitBooking[0]) >= count_rooms)
                {
                    MessageBox.Show("На эти даты номер забронирован. Выберите другую дату.");
                    return;
                }
                dt = dt.AddDays(1);
            }

            SQLClass.MyUpDate("INSERT INTO booking (user, dateFrom, dateTo, room_id) VALUES ('" + MainForm.Login + "', '" + IndateTimePicker.Value.ToString("yyyy-MM-dd") + "', '" + OutdateTimePicker.Value.ToString("yyyy-MM-dd") + "', '" + idRoom + "')");
            MessageBox.Show("Бронирование прошло успешно");
        }
    }
}
