#region Form Empty stuff
// just edit title, text
using System.Windows.Forms;

namespace r6Launcher.Forms
{
    public partial class FormEmpty : Form
    {
        public FormEmpty()
        {
            InitializeComponent();
        }
        internal string lblTitle(string title)
        {
            return this.Text = title;
        }
        internal string lblText(string text)
        {
            return TextLabel.Text = text;
        }
    }
}
#endregion