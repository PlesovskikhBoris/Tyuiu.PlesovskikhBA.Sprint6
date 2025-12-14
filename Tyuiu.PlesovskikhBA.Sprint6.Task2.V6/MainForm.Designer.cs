using Tyuiu.PlesovskikhBA.Sprint6.Task2.V6.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint6.Task2.V6
{
    partial class MainForm
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
            groupBoxTask = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxInput = new GroupBox();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            labelEnd = new Label();
            labelStart = new Label();
            groupBoxDone = new GroupBox();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Fx = new DataGridViewTextBoxColumn();
            labelDone = new Label();
            buttonInfo = new Button();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBox1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(481, 274);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.formula2;
            pictureBox1.Location = new Point(140, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxEnd);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(labelEnd);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Location = new Point(12, 292);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(310, 159);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(167, 46);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(100, 23);
            textBoxEnd.TabIndex = 2;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 46);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(167, 28);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(75, 15);
            labelEnd.TabIndex = 0;
            labelEnd.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 28);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(72, 15);
            labelStart.TabIndex = 0;
            labelStart.Text = "Старт шага:";
            // 
            // groupBoxDone
            // 
            groupBoxDone.Controls.Add(dataGridView1);
            groupBoxDone.Controls.Add(labelDone);
            groupBoxDone.Location = new Point(519, 12);
            groupBoxDone.Name = "groupBoxDone";
            groupBoxDone.Size = new Size(593, 439);
            groupBoxDone.TabIndex = 1;
            groupBoxDone.TabStop = false;
            groupBoxDone.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, Fx });
            dataGridView1.Location = new Point(6, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(114, 377);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Fx
            // 
            Fx.HeaderText = "Fx";
            Fx.Name = "Fx";
            Fx.Width = 50;
            // 
            // labelDone
            // 
            labelDone.AutoSize = true;
            labelDone.Location = new Point(6, 22);
            labelDone.Name = "labelDone";
            labelDone.Size = new Size(60, 15);
            labelDone.TabIndex = 0;
            labelDone.Text = "Результат";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(328, 301);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(63, 144);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(397, 301);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 144);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 463);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxDone);
            Controls.Add(groupBoxTask);
            Name = "MainForm";
            Text = "Form1";
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxDone.ResumeLayout(false);
            groupBoxDone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxTask;
        private PictureBox pictureBox1;
        private GroupBox groupBoxInput;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Label labelEnd;
        private Label labelStart;
        private GroupBox groupBoxDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label labelDone;
        private Button buttonInfo;
        private Button buttonDone;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Fx;
    }
}