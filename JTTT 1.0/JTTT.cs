using System;
using System.Windows.Forms;

namespace JTTT_1._0
{
    public partial class JTTT : Form
    {
        public JTTT()
        {
            InitializeComponent();
            TaskList.DataSource = Services.Instance.AllTasks.Tasks;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Services.Instance.AllTasks.ExecuteAll();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            //string fileAtt = Services.Instance.ActionRegister.GetAction(comboBox1.Text).DoAction(URL.Text, KeyWord.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Services.Instance.AllTasks.ClearAll();
        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            Services.Instance.AllTasks.Serialize();
        }

        private void DeSerialize_Click(object sender, EventArgs e)
        {
            Services.Instance.AllTasks.DeSerialize();
        }
    }
}
