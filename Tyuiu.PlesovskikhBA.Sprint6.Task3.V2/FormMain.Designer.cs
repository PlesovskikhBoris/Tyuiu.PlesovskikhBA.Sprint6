namespace Tyuiu.PlesovskikhBA.Sprint6.Task3.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTask_PBA;
        private TextBox textBoxTask_PBA;
        private DataGridView dataGridViewResult_PBA;
        private Button buttonExecute_PBA;
        private Button buttonInfo_PBA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTask_PBA = new Label();
            textBoxTask_PBA = new TextBox();
            dataGridViewResult_PBA = new DataGridView();
            buttonExecute_PBA = new Button();
            buttonInfo_PBA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PBA).BeginInit();
            SuspendLayout();
            // 
            // labelTask_PBA
            // 
            labelTask_PBA.AutoSize = true;
            labelTask_PBA.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelTask_PBA.Location = new Point(20, 20);
            labelTask_PBA.Name = "labelTask_PBA";
            labelTask_PBA.Size = new Size(67, 15);
            labelTask_PBA.TabIndex = 0;
            labelTask_PBA.Text = "Условие:";
            // 
            // textBoxTask_PBA
            // 
            textBoxTask_PBA.Location = new Point(20, 45);
            textBoxTask_PBA.Multiline = true;
            textBoxTask_PBA.Name = "textBoxTask_PBA";
            textBoxTask_PBA.ReadOnly = true;
            textBoxTask_PBA.ScrollBars = ScrollBars.Vertical;
            textBoxTask_PBA.Size = new Size(400, 80);
            textBoxTask_PBA.TabIndex = 1;
            textBoxTask_PBA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\nИсходный массив:\r\n-12  -4 -20   5  -5\r\n  2  15   1 -20   7\r\n 15 -15   2  11   5\r\n-19  -9  16   0   1\r\n 17  16   5  12  -8";
            // 
            // dataGridViewResult_PBA
            // 
            dataGridViewResult_PBA.AllowUserToAddRows = false;
            dataGridViewResult_PBA.AllowUserToDeleteRows = false;
            dataGridViewResult_PBA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PBA.Location = new Point(20, 140);
            dataGridViewResult_PBA.Name = "dataGridViewResult_PBA";
            dataGridViewResult_PBA.ReadOnly = true;
            dataGridViewResult_PBA.Size = new Size(400, 150);
            dataGridViewResult_PBA.TabIndex = 2;
            // 
            // buttonExecute_PBA
            // 
            buttonExecute_PBA.Location = new Point(240, 300);
            buttonExecute_PBA.Name = "buttonExecute_PBA";
            buttonExecute_PBA.Size = new Size(90, 25);
            buttonExecute_PBA.TabIndex = 3;
            buttonExecute_PBA.Text = "Выполнить";
            buttonExecute_PBA.Click += buttonExecute_Click;
            // 
            // buttonInfo_PBA
            // 
            buttonInfo_PBA.Location = new Point(340, 300);
            buttonInfo_PBA.Name = "buttonInfo_PBA";
            buttonInfo_PBA.Size = new Size(30, 25);
            buttonInfo_PBA.TabIndex = 4;
            buttonInfo_PBA.Text = "?";
            buttonInfo_PBA.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(450, 340);
            Controls.Add(labelTask_PBA);
            Controls.Add(textBoxTask_PBA);
            Controls.Add(dataGridViewResult_PBA);
            Controls.Add(buttonExecute_PBA);
            Controls.Add(buttonInfo_PBA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 2 | Плесовских Б. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PBA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
