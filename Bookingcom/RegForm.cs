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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegBTN_Click(object sender, EventArgs e)
        {
            if(NameTB.Text == "" || SurnameTB.Text == "" || LoginTB.Text == "" )
            {
                MessageBox.Show("Все поля обязательны для заполнения");
                return;
            }

            if(PasTB.Text == PasConfirmTB.Text)
            {
                SQLClass.MyUpDate("INSERT INTO users (login, pass, name, surname, admin) VALUE ('" + LoginTB.Text + "', '" + PasTB.Text + "', '" + NameTB.Text + "', '" + SurnameTB.Text + "', 0)");
                MessageBox.Show("Регистрация прошла успешно");
                Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
           
        }
    }
}
