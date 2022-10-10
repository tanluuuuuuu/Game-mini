namespace Assignment1
{
    partial class ChoosingLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosingLesson));
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VehicleTopic = new System.Windows.Forms.Button();
            this.SportTopic = new System.Windows.Forms.Button();
            this.FruitTopic = new System.Windows.Forms.Button();
            this.AnimalTopic = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(176)))), ((int)(((byte)(188)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(176)))), ((int)(((byte)(188)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.VehicleTopic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SportTopic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FruitTopic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AnimalTopic, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.VehicleTopic.TabIndex = 5;
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
            this.SportTopic.TabIndex = 4;
            this.SportTopic.Text = "Sport";
            this.SportTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SportTopic.UseVisualStyleBackColor = false;
            this.SportTopic.Click += new System.EventHandler(this.SportTopic_Click);
            // 
            // FruitTopic
            // 
            this.FruitTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(219)))));
            this.FruitTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FruitTopic.FlatAppearance.BorderSize = 0;
            this.FruitTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FruitTopic.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FruitTopic.Image = ((System.Drawing.Image)(resources.GetObject("FruitTopic.Image")));
            this.FruitTopic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FruitTopic.Location = new System.Drawing.Point(3, 3);
            this.FruitTopic.Name = "FruitTopic";
            this.FruitTopic.Size = new System.Drawing.Size(194, 194);
            this.FruitTopic.TabIndex = 3;
            this.FruitTopic.Text = "Fruit";
            this.FruitTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FruitTopic.UseVisualStyleBackColor = false;
            this.FruitTopic.Click += new System.EventHandler(this.selectFruit);
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
            this.AnimalTopic.TabIndex = 6;
            this.AnimalTopic.Text = "Animal";
            this.AnimalTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AnimalTopic.UseVisualStyleBackColor = false;
            this.AnimalTopic.Click += new System.EventHandler(this.AnimalTopic_Click);
            // 
            // ChoosingLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "ChoosingLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choosing Lesson";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button VehicleTopic;
        private Button SportTopic;
        private Button FruitTopic;
        private Button AnimalTopic;
    }
}