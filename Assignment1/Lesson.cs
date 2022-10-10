using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Media;

namespace Assignment1
{
    public partial class Lesson : Form
    {
        List<Bitmap> images = new List<Bitmap>();
        List<string> name = new List<string>();
        Random randomizer = new Random();
        string currentAns = "";
        int numQuestions = 0;
        int numCorrect = 0;
        int maxTime;
        int timeLeft;
        public Lesson(int _time)
        {
            InitializeComponent();
            maxTime = _time;
            timeLeft = maxTime;
            loadLesson();
            timeLabel.Text = timeLeft + " giây";
            timer1.Start();
        }

        private void loadLesson()
        {
            PropertyInfo[] props;
            if (Global.Instance.Topic == "Fruit")
            {
                props = typeof(Topic.Fruit).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
            }
            else if (Global.Instance.Topic == "Animal")
            {
                props = typeof(Topic.Animal).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
            }
            else if (Global.Instance.Topic == "Vehicle")
            {
                props = typeof(Topic.Vehicle).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
            }
            else
            {
                props = typeof(Topic.Sport).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
            }

            images = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.GetValue(null, null) as Bitmap).ToList();
            name = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.Name as string).ToList();

            numQuestions = images.Count();
            pictureBox1.Image = images[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            images.RemoveAt(0);
            currentAns = name[0];
            name.RemoveAt(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loadNextQuestion()
        {
            textBox1.Text = "";
            int idx = randomizer.Next(images.Count());
            pictureBox1.Image = images[idx];
            images.RemoveAt(idx);
            currentAns = name[idx];
            name.RemoveAt(idx);
        }

        private void restartTime()
        {
            timer1.Stop();
            timeLabel.Text = maxTime + " giây";
            timeLeft = maxTime;
            timer1.Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.ToLower() != currentAns.ToLower())
                {
                    MessageBox.Show(currentAns, "Sai");
                }
                else
                {
                    numCorrect += 1;
                }
                if (images.Count() > 0)
                {
                    loadNextQuestion();
                    restartTime();
                }
                else
                {
                    timer1.Stop();
                    Form currentForm = Form.ActiveForm;
                    Form lessonResultForm = new LessonResult(numQuestions, numCorrect);
                    if (currentForm != null)
                    {
                        currentForm.Hide();
                        lessonResultForm.Show();
                        lessonResultForm.BringToFront();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            timeLabel.Text = timeLeft + " giây";

            if (timeLeft == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(currentAns, "Hết thời gian");
                loadNextQuestion();
                restartTime();
            }
            else if (timeLeft <= 10)
            {
                timeLabel.ForeColor = Color.White;
                timeLabel.BackColor = Color.Red;
            }
        }

        private void skipQuestion(object sender, EventArgs e)
        {
            if (images.Count() > 0)
            {
                loadNextQuestion();
                restartTime();
            }
            else
            {
                timer1.Stop();
                Form currentForm = Form.ActiveForm;
                Form lessonResultForm = new LessonResult(numQuestions, numCorrect);
                if (currentForm != null)
                {
                    currentForm.Hide();
                    lessonResultForm.Show();
                    lessonResultForm.BringToFront();
                }
            }
        }
    }
}
