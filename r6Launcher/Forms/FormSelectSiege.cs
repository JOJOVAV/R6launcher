using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace r6Launcher.Forms
{
    public partial class FormSelectSiege : Form
    {
        /*System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
        System.Windows.Forms.Form formAdd = System.Windows.Forms.Application.OpenForms["FormAddSiege"];
        System.Windows.Forms.Form formSelect = System.Windows.Forms.Application.OpenForms["FormSelectSiege"];*/
        public FormSelectSiege()
        {
            InitializeComponent();
        }

        private void ResetClicked(object sender, EventArgs e)
        {
            var settings = new Properties.Settings();
            settings.Reset();
            settings.Save();
            comboBoxSelectSiege.Items.Clear();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            var settings = new Properties.Settings();
            var arrayopselect = settings.OperationSelect.Split(',').ToArray();
            comboBoxSelectSiege.Items.AddRange(arrayopselect);
        }

        private void comboBoxSelectSiege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectSiege.SelectedIndex != -1)
            {
                var pub = new Public();
                pub.SelectedSeason = comboBoxSelectSiege.SelectedItem.ToString();
            }
        }
    }
}
