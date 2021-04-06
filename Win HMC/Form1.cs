using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_HMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string username = bunifuTextBox1.Text;
            string password = bunifuTextBox2.Text;

            if (username.Trim() == string.Empty)
            {
                msgbox.Show(this, "Enter username.",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
                    duration: 3000);
                return;
            }

            if (password.Trim() == string.Empty)
            {
                msgbox.Show(this, "Enter password.",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
                    duration: 3000);
                return;
            }

            msgbox.Show(this, "Logged In Successfully",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                duration: 5000);
        }
    }
}

