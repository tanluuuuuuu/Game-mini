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
    public partial class LessonResult : Form
    {
        public LessonResult(int _numQuestions, int _numCorrect)
        {
            InitializeComponent();
            label1.Text = "Your point is: " + _numCorrect + "/" + _numQuestions;
            Global.Instance.resultDict[Global.Instance.Topic][0] = Math.Max(Global.Instance.resultDict[Global.Instance.Topic][0], _numCorrect) ;
            Global.Instance.resultDict[Global.Instance.Topic][1] = Math.Max(Global.Instance.resultDict[Global.Instance.Topic][1], _numQuestions);

            using (StreamWriter writetext = new StreamWriter(Global.Instance.FileSave))
            {
                foreach (KeyValuePair<string, List<int>> entry in Global.Instance.resultDict)
                {
                    writetext.Write(entry.Key + "\n");
                    writetext.Write(entry.Value[0] + "\n");
                    if (Global.Instance.Topic == entry.Key)
                        writetext.Write(_numQuestions + "\n");
                    else
                        writetext.Write(entry.Value[1] + "\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form currentForm = Form.ActiveForm;
            Form chooseLessonForm = new ChoosingLesson();
            if (currentForm != null)
            {
                currentForm.Hide();
                chooseLessonForm.Show();
                chooseLessonForm.BringToFront();
            }
        }
    }
}
