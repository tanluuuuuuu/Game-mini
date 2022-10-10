using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillPanelInfo(string topic)
        {
            int numCorrect = Global.Instance.resultDict[topic][0];
            int numQuestion = Global.Instance.resultDict[topic][1];
            labelTopic.Text = topic;
            labelCorrect.Text = numCorrect.ToString();
            labelNumQues.Text = numQuestion.ToString();
            progressBar.Maximum = numQuestion;
            progressBar.Value = numCorrect;
            panel1.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Global.Instance.Topic = "Fruit";
            fillPanelInfo("Fruit");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form currentForm = Form.ActiveForm;
            Form mainMenuForm = new MainMenu();
            if (currentForm != null)
            {
                currentForm.Hide();
                mainMenuForm.Show();
                mainMenuForm.BringToFront();
            }
        }

        private void RestartLesson(object sender, EventArgs e)
        {
            string topic = Global.Instance.Topic;
            Global.Instance.resultDict[topic][0] = 0;
            using (StreamWriter writetext = new StreamWriter(Global.Instance.FileSave))
            {
                foreach (KeyValuePair<string, List<int>> entry in Global.Instance.resultDict)
                {
                    writetext.Write(entry.Key + "\n");
                    writetext.Write(entry.Value[0] + "\n");
                    writetext.Write(entry.Value[1] + "\n");
                }
            }
            fillPanelInfo("Fruit");
            MessageBox.Show("Reset thành công");
        }

        private void AnimalTopic_Click(object sender, EventArgs e)
        {
            Global.Instance.Topic = "Animal";
            fillPanelInfo(Global.Instance.Topic);
        }

        private void VehicleTopic_Click(object sender, EventArgs e)
        {
            Global.Instance.Topic = "Vehicle";
            fillPanelInfo(Global.Instance.Topic);
        }

        private void SportTopic_Click(object sender, EventArgs e)
        {
            Global.Instance.Topic = "Sport";
            fillPanelInfo(Global.Instance.Topic);
        }
    }
}
