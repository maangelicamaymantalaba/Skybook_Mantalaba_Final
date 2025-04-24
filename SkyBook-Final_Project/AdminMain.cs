using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBook_Final_Project
{
    public partial class AdminMain : Form
    {
        private bool sidebarExpanded = false;
        private int sidebarFullWidth = 250;
        private int sidebarCollapsedWidth = 52;
        private int sidebarSpeed = 20;
        public AdminMain()
        {
            InitializeComponent();
            flpSidebar.Width = sidebarCollapsedWidth;
        }

        public AddUsers Form11
        {
            get => default;
            set
            {
            }
        }

        public AdminSales Form10
        {
            get => default;
            set
            {
            }
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            AddUsers addUsersForm = new AddUsers();

            addUsersForm.Show();

            this.Hide();
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sidebarTransition_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                flpSidebar.Width -= sidebarSpeed;
                if (flpSidebar.Width <= sidebarCollapsedWidth)
                {
                    flpSidebar.Width = sidebarCollapsedWidth;
                    sidebarExpanded = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                flpSidebar.Width += sidebarSpeed;
                if (flpSidebar.Width >= sidebarFullWidth)
                {
                    flpSidebar.Width = sidebarFullWidth;
                    sidebarExpanded = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            AdminSales adminSalesForm = new AdminSales();

            adminSalesForm.Show();

            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin userLoginForm = new UserLogin();

            userLoginForm.Show();

            this.Hide();
        }
    }
}
