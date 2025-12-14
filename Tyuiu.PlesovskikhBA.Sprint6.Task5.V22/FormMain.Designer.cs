namespace Tyuiu.PlesovskikhBA.Sprint6.Task5.V22
{
    partial class FormMain
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            buttonChek = new Button();
            buttonInfo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(569, 27);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 36);
            button1.TabIndex = 16;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(523, 48);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 17);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 0;
            label2.Text = "Результат вывести в таблице";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(0, 72);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(302, 358);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 20);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(218, 334);
            dataGridView1.TabIndex = 0;
            // 
            // buttonChek
            // 
            buttonChek.Location = new Point(811, 27);
            buttonChek.Margin = new Padding(3, 2, 3, 2);
            buttonChek.Name = "buttonChek";
            buttonChek.Size = new Size(114, 36);
            buttonChek.TabIndex = 19;
            buttonChek.Text = "Сохранить";
            buttonChek.UseVisualStyleBackColor = true;
            buttonChek.Click += button3_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(690, 27);
            buttonInfo.Margin = new Padding(3, 2, 3, 2);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(116, 36);
            buttonInfo.TabIndex = 18;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 454);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(buttonChek);
            Controls.Add(buttonInfo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 22 | Плесовских Б. А.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Button buttonChek;
        private Button buttonInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
    }
}
