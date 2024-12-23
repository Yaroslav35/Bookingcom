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
    public partial class AdminCitiesForm : Form
    {
        public AdminCitiesForm()
        {
            InitializeComponent();
            Text = "Форма управления таблицей \"Города\"";
        }

        private void DelSityClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach(Control control in panel1.Controls)
            {
                if(control.Location == new Point(12, y))
                {
                    SQLClass.MyUpDate("DELETE FROM cities WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Успешно удалено");
                }
            }
            AdminCitiesForm_Load(sender, e);
        }


        private void AddCityButton_Click(object sender, EventArgs e)
        {
            if(AddCityTextBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO cities (Name) VALUES ('" + AddCityTextBox.Text + "')");
                MessageBox.Show("Успешно добавлено");
                AddCityTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Вы забыли ввести название города");
            }
            AdminCitiesForm_Load(sender, e);
        }

        private void AdminCitiesForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);

            List<string> cities = SQLClass.MySelect("SELECT id, Name FROM cities ORDER BY Name");

            int y = 45;
            for (int i = 0; i < cities.Count; i += 2)
            {
                Label lbl = new Label();
                lbl.Text = cities[i + 1];
                lbl.Location = new Point(12, y);
                lbl.Size = new Size(200, 30);
                lbl.Tag = cities[i];
                panel1.Controls.Add(lbl);

                Button button = new Button();
                button.Location = new Point(250, y);
                button.Size = new Size(80, 30);
                button.Text = "Удалить";
                button.Click += new EventHandler(DelSityClick);
                panel1.Controls.Add(button);

                y += 30;
            }
        }
    }
}
