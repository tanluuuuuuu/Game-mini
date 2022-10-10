namespace Assignment1
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonLearning = new System.Windows.Forms.Button();
            this.buttonDashBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLearning
            // 
            this.buttonLearning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLearning.BackColor = System.Drawing.Color.White;
            this.buttonLearning.FlatAppearance.BorderSize = 0;
            this.buttonLearning.Image = ((System.Drawing.Image)(resources.GetObject("buttonLearning.Image")));
            this.buttonLearning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLearning.Location = new System.Drawing.Point(81, 75);
            this.buttonLearning.Name = "buttonLearning";
            this.buttonLearning.Size = new System.Drawing.Size(184, 54);
            this.buttonLearning.TabIndex = 0;
            this.buttonLearning.Text = "          Start Learning";
            this.buttonLearning.UseVisualStyleBackColor = false;
            this.buttonLearning.Click += new System.EventHandler(this.onStartLearning);
            // 
            // buttonDashBoard
            // 
            this.buttonDashBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDashBoard.BackColor = System.Drawing.Color.White;
            this.buttonDashBoard.FlatAppearance.BorderSize = 0;
            this.buttonDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashBoard.Image")));
            this.buttonDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashBoard.Location = new System.Drawing.Point(81, 147);
            this.buttonDashBoard.Name = "buttonDashBoard";
            this.buttonDashBoard.Size = new System.Drawing.Size(184, 54);
            this.buttonDashBoard.TabIndex = 1;
            this.buttonDashBoard.Text = "     Dash Board";
            this.buttonDashBoard.UseVisualStyleBackColor = false;
            this.buttonDashBoard.Click += new System.EventHandler(this.buttonDashBoard_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.buttonDashBoard);
            this.Controls.Add(this.buttonLearning);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLearning;
        private Button buttonDashBoard;
    }
}