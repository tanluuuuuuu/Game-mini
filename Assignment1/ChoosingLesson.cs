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
    public partial class ChoosingLesson : Form
    {
        public ChoosingLesson()
        {
            InitializeComponent();
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

        private void selectFruit(object sender, EventArgs e)
        {
            Global.Instance.Topic = "Fruit";
            Form currentForm = Form.ActiveForm;
            Form lessonSetting = new LessonSetting(currentForm);
            if (currentForm != null)
            {
                lessonSetting.Show();
                lessonSetting.BringToFront();
            }
        }

        private void AnimalTopic_Click(object sender, EventArgs e)
        {
            Global.Instance.Topic = "Animal";
            Form currentForm = Form.ActiveForm;
            Form lessonSetting = new LessonSetting(currentForm);
            if (currentForm != null)
            {
                lessonSetting.Show();
                lessonSetting.BringToFront();
            }
        }

        private void VehicleTopic_Click(object sender, EventArgs e)
        {
            Global.Instance.Topic = "Vehicle";
            Form currentForm = Form.ActiveForm;
            Form lessonSetting = new LessonSetting(currentForm);
            if (currentForm != null)
            {
                lessonSetting.Show();
                lessonSetting.BringToFront();
            }
        }

        private void SportTopic_Click(object sender, EventArgs e)
        {
            Global.Instance.Topic = "Sport";
            Form currentForm = Form.ActiveForm;
            Form lessonSetting = new LessonSetting(currentForm);
            if (currentForm != null)
            {
                lessonSetting.Show();
                lessonSetting.BringToFront();
            }
        }
    }
}
