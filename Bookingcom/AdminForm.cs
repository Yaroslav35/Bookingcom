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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminCitiesForm adminCitiesForm = new AdminCitiesForm();
            adminCitiesForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHotelsForm adminHolesForm = new AdminHotelsForm();
            adminHolesForm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminRoomsForm adminRoomsForm = new AdminRoomsForm();
            adminRoomsForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminUsersForm adminUsersForm = new AdminUsersForm();  
            adminUsersForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminBookingForm adminBookingForm = new AdminBookingForm();
            adminBookingForm.ShowDialog();
        }
    }
}
