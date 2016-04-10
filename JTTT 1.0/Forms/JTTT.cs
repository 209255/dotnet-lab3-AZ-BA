using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JTTT_1._0
{
    public partial class JTTT : Form
    {
        public JTTT()
        {
            InitializeComponent();
            Services.Instance.Tasks.LoadTasks();
            TaskList.DataSource = Services.Instance.Tasks.Tasks;
            actionsBox.Items.AddRange(Services.Instance.ActionRegister.GetActionNames().ToArray());
            reactionsBox.Items.AddRange(Services.Instance.ReactionRegister.GetReactionNames().ToArray());
            HideActionView();
            HideReactionView();
        }


        private void Execute_Click(object sender, EventArgs e)
        {
            Services.Instance.Tasks.ExecuteAll();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            var action = Services.Instance.ActionRegister.GetAction(actionsBox.Text);
            var reaction = Services.Instance.ReactionRegister.GetReaction(reactionsBox.Text);
            var actionModel = action.GetEmptyModel();
            if (actionModel == null) return;
            actionModel.FillModel(new string[] { actionArg0.Text, actionArg1.Text });
            var reactionModel = reaction.GetEmptyModel();
            if (reactionModel == null) return;
            reactionModel.FillModel(new string[] { actionArg0.Text, reactionArg0.Text });
            Services.Instance.Tasks.AddTaskToDb(new Task(action, reaction, actionModel, reactionModel, TaskName.Text));
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Services.Instance.Tasks.ClearAllTaskFromDb();
        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            Services.Instance.Tasks.Serialize();
        }

        private void DeSerialize_Click(object sender, EventArgs e)
        {
            Services.Instance.Tasks.Deserialize();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = Services.Instance.ActionRegister.GetAction(actionsBox.Text).GetView();
            if (view != null)
            {
                labelActionDescription.Text = view.description;
                labelActionArg0.Text = view.arg0;
                labelActionArg1.Text = view.arg1;
                ShowActionView();
                return;
            }
            HideActionView();

        }

        private void HideActionView()
        {
            labelActionDescription.Hide();
            labelActionArg0.Hide();
            labelActionArg1.Hide();
            actionArg0.Hide();
            actionArg1.Hide();
        }

        private void ShowActionView()
        {
            labelActionDescription.Show();
            labelActionArg0.Show();
            labelActionArg1.Show();
            actionArg0.Show();
            actionArg1.Show();
        }

        private void reactionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = Services.Instance.ReactionRegister.GetReaction(reactionsBox.Text).GetView();
            if (view != null)
            {
                labelReactionDescription.Text = view.description;
                labelReactionArg0.Text = view.arg0;
                labelReactionDescription.Show();
                ShowReactionView();
                return;
            }
            HideReactionView();
        }

        private void HideReactionView()
        {
            labelReactionDescription.Hide();
            labelReactionArg0.Hide();
            reactionArg0.Hide();
        }

        private void ShowReactionView()
        {
            if (labelReactionArg0.Text != null & labelReactionArg0.Text != "")
            {
                labelReactionArg0.Show();
                reactionArg0.Show();
                return;
            }
            labelReactionArg0.Hide();
            reactionArg0.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherInfoForm form = new WeatherInfoForm();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void actionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
