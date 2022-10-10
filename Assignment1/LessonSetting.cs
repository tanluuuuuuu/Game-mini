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
    public partial class LessonSetting : Form
    {
        Form parentForm;
        string topic;
        public LessonSetting(Form _parentForm)
        {
            InitializeComponent();
            parentForm = _parentForm;
            numericUpDown1.Value = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Hãy đặt thời gian kiểm tra nhiều hơn em nhé");
                return;
            }
            Form currentForm = Form.ActiveForm;
            Form lessonForm = new Lesson(Convert.ToInt32(numericUpDown1.Value));
            if (currentForm != null)
            {
                currentForm.Hide();
                parentForm.Hide();
                lessonForm.Show();
                lessonForm.BringToFront();
            }
        }
    }
}
