using System.Windows.Forms;

namespace SkyBook_Final_Project
{
    public partial class main : Form
    {
        private bool sidebarExpanded = false;
        private int sidebarFullWidth = 250;
        private int sidebarCollapsedWidth = 48;
        private int sidebarSpeed = 20;
        public main()
        {
            InitializeComponent();
            flpSidebar.Width = sidebarCollapsedWidth;
            this.Resize += new EventHandler(Form1_Resize);
        }

        public UpdateandCancel Form3
        {
            get => default;
            set
            {
            }
        }

        public SearchandBook Form2
        {
            get => default;
            set
            {
            }
        }

        public AddMembers Form4
        {
            get => default;
            set
            {
            }
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
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

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnSearchBookFlight_Click(object sender, EventArgs e)
        {
            SearchandBook form2 = new SearchandBook();
            form2.Show();
            this.Hide();
        }

        private void btnViewUpdateReservations_Click(object sender, EventArgs e)
        {
            UpdateandCancel form3 = new UpdateandCancel();
            form3.Show();
            this.Hide();
        }

        private void btnAddCrewMembers_Click(object sender, EventArgs e)
        {
            AddMembers form4 = new AddMembers();
            form4.Show();
            this.Hide();
        }

        private void btnPassengerCrewList_Click(object sender, EventArgs e)
        {
            List form5 = new List();
            form5.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            /*  int minLogoWidth = 251;
              int minLogoHeight = 222;

              int minTitleWidth = 662;
              int minTitleHeight = 204;

              pictureBox2.Width = Math.Max(minLogoWidth, this.ClientSize.Width / 4);
              pictureBox2.Height = Math.Max(minLogoHeight, this.ClientSize.Height / 4);


              pictureBox2.Left = (this.ClientSize.Width - pictureBox2.Width) / 2;
              pictureBox2.Top = (this.ClientSize.Height - pictureBox2.Height) / 3;

              pictureBox1.Width = Math.Max(minTitleWidth, this.ClientSize.Width / 3);
              pictureBox1.Height = Math.Max(minTitleHeight, this.ClientSize.Height / 9);


              pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
              pictureBox1.Top = pictureBox2.Bottom + 30;
            */
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin userLoginForm = new UserLogin();

            userLoginForm.Show();

            this.Hide();
        }
    }

}

