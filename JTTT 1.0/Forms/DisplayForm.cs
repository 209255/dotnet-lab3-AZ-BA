using System.Drawing;
using System.Windows.Forms;

namespace JTTT_1._0
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        public void SetImg (string path)
        {
            Image img = Image.FromFile(path);
            displayPicBox.Image = img;
        }

        public void SetDescription(string description)
        {
            descriptionDisplBox.Text = description;
        }
    }
}
