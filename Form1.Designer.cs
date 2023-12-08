namespace Yolov8_Form
{
    partial class Form1
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
            Button btn_open;
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            btn_detect = new Button();
            btn_open = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_open
            // 
            btn_open.Location = new Point(12, 215);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(75, 23);
            btn_open.TabIndex = 2;
            btn_open.Text = "Open";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(307, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(666, 396);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btn_detect
            // 
            btn_detect.Location = new Point(119, 215);
            btn_detect.Name = "btn_detect";
            btn_detect.Size = new Size(75, 23);
            btn_detect.TabIndex = 3;
            btn_detect.Text = "Detect";
            btn_detect.UseVisualStyleBackColor = true;
            btn_detect.Click += btn_detect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 629);
            Controls.Add(btn_detect);
            Controls.Add(btn_open);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button btn_detect;
    }
}