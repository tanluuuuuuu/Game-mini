namespace Assignment1
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restartLesson = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelNumQues = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VehicleTopic = new System.Windows.Forms.Button();
            this.SportTopic = new System.Windows.Forms.Button();
            this.AnimalTopic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.restartLesson);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.labelCorrect);
            this.panel1.Controls.Add(this.labelNumQues);
            this.panel1.Controls.Add(this.labelTopic);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(418, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 553);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // restartLesson
            // 
            this.restartLesson.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartLesson.Location = new System.Drawing.Point(129, 276);
            this.restartLesson.Name = "restartLesson";
            this.restartLesson.Size = new System.Drawing.Size(240, 56);
            this.restartLesson.TabIndex = 8;
            this.restartLesson.Text = "Đặt lại bài học";
            this.restartLesson.UseVisualStyleBackColor = true;
            this.restartLesson.Click += new System.EventHandler(this.RestartLesson);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiến độ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(225, 195);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(227, 29);
            this.progressBar.TabIndex = 6;
            this.progressBar.Value = 50;
            // 
            // labelCorrect
            // 
            this.labelCorrect.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCorrect.Location = new System.Drawing.Point(225, 125);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(236, 44);
            this.labelCorrect.TabIndex = 5;
            this.labelCorrect.Text = "label6";
            this.labelCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNumQues
            // 
            this.labelNumQues.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumQues.Location = new System.Drawing.Point(225, 68);
            this.labelNumQues.Name = "labelNumQues";
            this.labelNumQues.Size = new System.Drawing.Size(236, 44);
            this.labelNumQues.TabIndex = 4;
            this.labelNumQues.Text = "label5";
            this.labelNumQues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTopic
            // 
            this.labelTopic.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTopic.Location = new System.Drawing.Point(225, 9);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(236, 44);
            this.labelTopic.TabIndex = 3;
            this.labelTopic.Text = "label4";
            this.labelTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số câu đúng";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số câu hỏi";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủ đề";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(219)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 194);
            this.button2.TabIndex = 0;
            this.button2.Text = "Fruit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.VehicleTopic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SportTopic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AnimalTopic, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // VehicleTopic
            // 
            this.VehicleTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(219)))));
            this.VehicleTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleTopic.FlatAppearance.BorderSize = 0;
            this.VehicleTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleTopic.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehicleTopic.Image = ((System.Drawing.Image)(resources.GetObject("VehicleTopic.Image")));
            this.VehicleTopic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VehicleTopic.Location = new System.Drawing.Point(3, 203);
            this.VehicleTopic.Name = "VehicleTopic";
            this.VehicleTopic.Size = new System.Drawing.Size(194, 194);
            this.VehicleTopic.TabIndex = 8;
            this.VehicleTopic.Text = "Vehicle";
            this.VehicleTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VehicleTopic.UseVisualStyleBackColor = false;
            this.VehicleTopic.Click += new System.EventHandler(this.VehicleTopic_Click);
            // 
            // SportTopic
            // 
            this.SportTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(219)))));
            this.SportTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SportTopic.FlatAppearance.BorderSize = 0;
            this.SportTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SportTopic.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SportTopic.Image = ((System.Drawing.Image)(resources.GetObject("SportTopic.Image")));
            this.SportTopic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SportTopic.Location = new System.Drawing.Point(203, 203);
            this.SportTopic.Name = "SportTopic";
            this.SportTopic.Size = new System.Drawing.Size(194, 194);
            this.SportTopic.TabIndex = 7;
            this.SportTopic.Text = "Sport";
            this.SportTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SportTopic.UseVisualStyleBackColor = false;
            this.SportTopic.Click += new System.EventHandler(this.SportTopic_Click);
            // 
            // AnimalTopic
            // 
            this.AnimalTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(219)))));
            this.AnimalTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimalTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimalTopic.FlatAppearance.BorderSize = 0;
            this.AnimalTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnimalTopic.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimalTopic.Image = ((System.Drawing.Image)(resources.GetObject("AnimalTopic.Image")));
            this.AnimalTopic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AnimalTopic.Location = new System.Drawing.Point(203, 3);
            this.AnimalTopic.Name = "AnimalTopic";
            this.AnimalTopic.Size = new System.Drawing.Size(194, 194);
            this.AnimalTopic.TabIndex = 9;
            this.AnimalTopic.Text = "Animal";
            this.AnimalTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AnimalTopic.UseVisualStyleBackColor = false;
            this.AnimalTopic.Click += new System.EventHandler(this.AnimalTopic_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash Board";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelCorrect;
        private Label labelNumQues;
        private Label labelTopic;
        private Label label4;
        private ProgressBar progressBar;
        private Button restartLesson;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button VehicleTopic;
        private Button SportTopic;
        private Button AnimalTopic;
    }
}