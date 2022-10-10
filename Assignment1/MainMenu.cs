namespace Assignment1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void changeForm(Form nextForm)
        {
            Form currentForm = Form.ActiveForm;
            if (currentForm != null)
            {
                currentForm.Hide();
                nextForm.Show();
                nextForm.BringToFront();
            }
        }

        private void onStartLearning(object sender, EventArgs e)
        {
            Form choosingLessonForm = new ChoosingLesson();
            changeForm(choosingLessonForm);
        }

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            Form dashboardForm = new DashBoard();
            changeForm(dashboardForm);
        }
    }
}