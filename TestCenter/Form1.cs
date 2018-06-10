using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCenter
{
    public partial class Form1 : Form        
    {
        bool moveflag = false;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moveflag = true;
            lastLocation = e.Location;
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moveflag = false;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveflag)
            {
                this.Location = new Point(
                 (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            
            if(this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            if (mnuPanel.Width != 33)
                mnuPanel.Width = 33;
            else
                mnuPanel.Width = 150;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
