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
    public partial class AdminBookingForm : Form
    {
        public AdminBookingForm()
        {
            InitializeComponent();
            Text = "Форма управления таблицей \"Бронирования\"";
        }

        private void AdminBookingForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);

            List<string> bookinglist = SQLClass.MySelect("SELECT booking.room_id, booking.user, booking.dateFrom, booking.dateTo, rooms.name, hotels.name "+
                                                            "FROM booking " +
                                                            "JOIN rooms ON rooms.id = booking.room_id " + 
                                                            "JOIN hotels ON hotels.id = rooms.id_hotel " + 
                                                            "ORDER BY booking.dateFrom");

            int y = 45;
            for (int i = 0; i < bookinglist.Count; i += 6)
            {
                //Пользователь
                Label lbl0 = new Label();
                lbl0.Text = bookinglist[i+1];
                lbl0.Location = new Point(10, y);
                lbl0.Size = new Size(130, 30);
                lbl0.Tag = bookinglist[i];
                lbl0.AccessibleDescription = bookinglist[i+2];      //дата заезда
                lbl0.AccessibleName = bookinglist[i+3];             //дата выезда
                panel1.Controls.Add(lbl0);

                //Дата заезда
                Label lbl1 = new Label();
                lbl1.Text = bookinglist[i + 2];
                lbl1.Location = new Point(150, y);
                lbl1.Size = new Size(100, 30);
                panel1.Controls.Add(lbl1);

                //Дата выезда
                Label lbl2 = new Label();
                lbl2.Text = bookinglist[i + 3];
                lbl2.Location = new Point(300, y);
                lbl2.Size = new Size(100, 30);
                panel1.Controls.Add(lbl2);

                //Номер
                Label lbl3 = new Label();
                lbl3.Text = bookinglist[i + 4];
                lbl3.Location = new Point(450, y);
                lbl3.Size = new Size(200, 30);
                panel1.Controls.Add(lbl3);

                //Гостиница
                Label lbl4 = new Label();
                lbl4.Text = bookinglist[i + 5];
                lbl4.Location = new Point(700, y);
                lbl4.Size = new Size(200, 30);
                panel1.Controls.Add(lbl4);

                //Удаление
                Button button = new Button();
                button.Location = new Point(950, y);
                button.Size = new Size(80, 30);
                button.Text = "Удалить";
                button.Click += new EventHandler(DelBookingClick);
                panel1.Controls.Add(button);

                y += 30;
            }
        }

        
        private void DelBookingClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(10, y))
                {
                    SQLClass.MyUpDate("DELETE FROM booking" +
                                        " WHERE user = '" + control.Text + "'" +
                                        " AND room_id = '" + control.Tag + "'" +
                                        " AND dateFrom = '" + Convert.ToDateTime(control.AccessibleDescription).ToString("yyyy-MM-dd") + "'" +
                                        " AND dateTo = '" + Convert.ToDateTime(control.AccessibleName).ToString("yyyy-MM-dd") + "'");
                    MessageBox.Show("Успешно удалено");
                }
            }
            AdminBookingForm_Load(sender, e);
        }
    }
}
