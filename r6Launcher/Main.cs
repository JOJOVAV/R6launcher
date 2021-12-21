#region Using
using System;
using System.Windows.Forms;
using System.IO;
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
        private string Path;
        private bool NeedBE_Off;
        private bool isCancelled;
        public Main()
        {
            InitializeComponent();
            customMenu();
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
            //Forms.FormEmpty formEmpty = new Forms.FormEmpty();
            //OpenChildForm(formEmpty, sender);
            //formEmpty.lblText("Playing...");
            var settings = new Properties.Settings();
            if (!string.IsNullOrWhiteSpace(settings.Currently_Op))
            {
                //formEmpty.lblText(settings.Currently_Op + " is starting soon..");
                //GetPaths(settings.Currently_Op);
                if (isCancelled == false)
                {
                    Checking();
                    if (!string.IsNullOrEmpty(STARTEXE))
                    {
                        //formEmpty.lblText("Starting " + STARTEXE + " !\nWith BattlEye off? " + NeedBE_Off);
                        //  This start R6 Exe, no need Batch /.bat
                        Process process = new Process();
                        process.StartInfo.FileName = Path + "\\" + STARTEXE;
                        if (NeedBE_Off == true) { process.StartInfo.Arguments = " /belaunch"; }
                        process.Start();
                        Log.SpecificLog(STARTEXE + " Belaunch? " + NeedBE_Off + " Started!", "StartGame");
                        process.Exited += delegate
                        {
                            Log.WriteLog("R6 Got Exited");
                            activeForm.Close();
                        };
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
        private void Checking()
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
        /*private void GetPaths(string season)
        {
            // IF no Select download Path
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.Description = "Select your " + season + " Siege Folder";
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK & result != DialogResult.Cancel)
            {
                // Set Starting Path
                Path = folderDlg.SelectedPath;
                Log.WriteLog(Path);
                isCancelled = false;
            }
            else
            {
                Log.WriteLog("Folder Selection cancelled");
                isCancelled = true;
            }

        }*/
        #endregion
#region EndFrom
    }
}
#endregion