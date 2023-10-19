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
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void workerButton_Click(object sender, EventArgs e)
        {
            LoggingView loggingView = new LoggingView();
            loggingView.ShowDialog();
            loggingView.Dispose();
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            GuestSign_inView guestSign_InView = new GuestSign_inView();
            guestSign_InView.ShowDialog();
            guestSign_InView.Dispose();
        }
    }
}
