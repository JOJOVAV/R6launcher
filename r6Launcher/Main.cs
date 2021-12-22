#region Using
using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Diagnostics;
#endregion
#region StartFrom
namespace r6Launcher
{
    public partial class Main : Form
    {
        #endregion
        #region StartStuff
        //variables
        private Form activeForm;
        private Button currentButton;
        private string STARTEXE;
        private bool NeedBE_Off;
        public Main()
        {
            InitializeComponent();
            customMenu();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            var settings = new Properties.Settings();
            settings.Currently_Op = null;
            settings.Save();
        }
        #endregion
        #region Clicked Events
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            showMenu(panelSubMenu);
        }
        //opens the form add siege
        private void buttonAddSiege_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddSiege(), sender);
        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //array for closing siege
            Close();
        }
        private void buttonSelectSiege_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSelectSiege(), sender);
        }
        //start r6
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            var settings = new Properties.Settings();
            if (!string.IsNullOrWhiteSpace(settings.Currently_Op))
            {
                if (Public.isCancelled == false)
                {
                    if (!string.IsNullOrWhiteSpace(settings.Saved_Path))
                    {
                        string _Path = settings.Saved_Path;
                        StartR6(_Path);
                    }     
                }
                else
                {
                    string[] splitted = settings.SavedPathOps.Split('|');
                    foreach (string file in splitted)
                    {
                        string[] splittedfile = file.Split('*');
                        string Path = splittedfile.First();
                        string season = splittedfile.Last();
                        if (season == settings.Currently_Op)
                        {
                            //Log.WriteLog(Path + " " + season);
                            StartR6(Path);
                        }
                    }
                }
            }
        }
        #endregion
        #region Menu, stuffs
        //hiding the extra menu
        private void customMenu()
        {
            panelSubMenu.Visible = false;

        }
        //show the extra menu
        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void Reset()
        {
            labelTitle.Text = "Rainbow Six Launcher";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        //active the buttons of the side menu
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton = (Button)btnSender;
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMainPanel.Controls.Add(childForm);
            this.panelMainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
        #endregion
        #region Other Voids
        private void Checking(string Path)
        {
            NeedBE_Off = true;
            if (File.Exists(Path + "\\RainbowSixGame.exe")) //Checking old RainbowSixGame.exe
            {
                STARTEXE = "RainbowSixGame.exe";
                return;
            }
            if (File.Exists(Path + "\\LumaPlay_x64.exe")) //Checking LumaPlay_x64.exe
            {
                STARTEXE = "LumaPlay_x64.exe";
                NeedBE_Off = false;
                return;
            }
            if (Public.useVulkan)
            {
                if (File.Exists(Path + "\\RainbowSix_Vulkan.exe")) //Checking RainbowSix_Vulkan.exe
                {
                    STARTEXE = "RainbowSix_Vulkan.exe";
                }
            }
            else
            {
                if (File.Exists(Path + "\\RainbowSix_BE.exe")) //Checking RainbowSix_BE.exe
                {
                    STARTEXE = "RainbowSix.exe";
                }
                if (File.Exists(Path + "\\RainbowSix.exe")) //Checking RainbowSix.exe
                {
                    STARTEXE = "RainbowSix.exe";
                }
            }
        }
        private void StartR6(string Path)
        {
            Checking(Path);
            if (!string.IsNullOrEmpty(STARTEXE))
            {
                if (File.Exists(Path + "\\" + STARTEXE))
                {
                    Process process = new Process();
                    process.StartInfo.FileName = Path + "\\" + STARTEXE;
                    if (NeedBE_Off == true) { process.StartInfo.Arguments = " /belaunch"; }
                    process.EnableRaisingEvents = true;
                    process.Start();
                    Log.SpecificLog(STARTEXE + " Belaunch? " + NeedBE_Off + " Started!", "StartGame");
                    process.Exited += delegate
                    {
                        Log.WriteLog("R6 Got Exited");
                        //activeForm.Close();
                    };
                }
            }
        }
        #endregion
        #region EndFrom
    }
}
#endregion