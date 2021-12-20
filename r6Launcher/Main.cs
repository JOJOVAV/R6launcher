﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace r6Launcher
{
    public partial class Main : Form
    {
        //variables
        private Form activeForm;
        private Button currentButton;
        private string STARTEXE;
        private string Path;
        private bool NeedBE_Off;
        /*Form formAdd = new Form();
        Form formSelect = new Form();*/
        /*System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
        System.Windows.Forms.Form formAdd = System.Windows.Forms.Application.OpenForms["FormAddSiege"];
        System.Windows.Forms.Form formSelect = System.Windows.Forms.Application.OpenForms["FormSelectSiege"];*/

        public Main()
        {
            InitializeComponent();
            customMenu();
            /*if (formSelect != activeForm)
            {
                buttonPlay.Enabled = false;
            }*/
            /*else if ()
            {
                buttonPlay.Enabled = true;
            }*/

        }
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

        //the user settings
        public void getSettings()
        {
            

            
        }
        
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            showMenu(panelSubMenu);
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

        private void Reset()
        {
            labelTitle.Text = "Rainbow Six Launcher";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void buttonSelectSiege_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSelectSiege(), sender);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            var pub = new Public();
            if (!string.IsNullOrEmpty(pub.SelectedSeason))
            { 

            }
        }
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
            if (/*CheckBox_Vulkan.Checked == true*/false)
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}