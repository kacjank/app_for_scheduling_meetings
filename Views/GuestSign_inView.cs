using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_do_awizacji
{
    public partial class GuestSign_inView : Form
    {
        public GuestSign_inView()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Czy na pewno chcesz wyjść? Niezapisane dane zostaną utracone.",
                "Powrót do menu głównego",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
