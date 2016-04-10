﻿using System;
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
           
        }


        private void Execute_Click(object sender, EventArgs e)
        {
            Services.Instance.Tasks.ExecuteAll();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            var action = Services.Instance.ActionRegister.GetAction(actionsBox.Text);
            var reaction = Services.Instance.ReactionRegister.GetReaction(reactionsBox.Text);
            var actionModel = action.GetEmptyModel() as MFindImgByKeyInDescription;
            if (actionModel == null) return;
            actionModel.URL = URL.Text;
            actionModel.KeyWord = KeyWord.Text;
            var reactionModel = reaction.GetEmptyModel() as MDowdnloadImgSendEmai;
            if (reactionModel == null) return;
            reactionModel.EmailReceiverAddress = EmailAdress.Text;
            reactionModel.URL = URL.Text;
            Task task = new Task(action, reaction, actionModel, reactionModel,TaskName.Text);
            Services.Instance.Tasks.AddTask(task);
            Services.Instance.Tasks.AddTaskToDb(task);
       }

        private void Clear_Click(object sender, EventArgs e)
        {
            Services.Instance.Tasks.ClearAll();
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

        }

        private void reactionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
