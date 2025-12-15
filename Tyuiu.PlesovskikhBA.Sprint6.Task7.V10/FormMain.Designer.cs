namespace Tyuiu.PlesovskikhBA.Sprint6.Task7.V10
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
            components = new System.ComponentModel.Container();
            panelBotton_PBA = new Panel();
            buttonSave_PBA = new Button();
            buttonDone_PBA = new Button();
            buttonOpen_PBA = new Button();
            buttonHelp_PBA = new Button();
            panelTask_PBA = new Panel();
            groupBoxTask_PBA = new GroupBox();
            pictureBox_PBA = new PictureBox();
            labelTask_PBA = new Label();
            panelInputData_PBA = new Panel();
            groupBoxInput_PBA = new GroupBox();
            dataGridViewIn_PBA = new DataGridView();
            panelResult_PBA = new Panel();
            groupBoxOutput_PBA = new GroupBox();
            dataGridViewOut_PBA = new DataGridView();
            splitter_PBA = new Splitter();
            openFileDialogTask_PBA = new OpenFileDialog();
            toolTipButton_PBA = new ToolTip(components);
            saveFileDialogMatrix_PBA = new SaveFileDialog();
            panelBotton_PBA.SuspendLayout();
            panelTask_PBA.SuspendLayout();
            groupBoxTask_PBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_PBA).BeginInit();
            panelInputData_PBA.SuspendLayout();
            groupBoxInput_PBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PBA).BeginInit();
            panelResult_PBA.SuspendLayout();
            groupBoxOutput_PBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PBA).BeginInit();
            SuspendLayout();
            // 
            // panelBotton_PBA
            // 
            panelBotton_PBA.Controls.Add(buttonSave_PBA);
            panelBotton_PBA.Controls.Add(buttonDone_PBA);
            panelBotton_PBA.Controls.Add(buttonOpen_PBA);
            panelBotton_PBA.Controls.Add(buttonHelp_PBA);
            panelBotton_PBA.Dock = DockStyle.Top;
            panelBotton_PBA.Location = new Point(0, 0);
            panelBotton_PBA.Margin = new Padding(3, 2, 3, 2);
            panelBotton_PBA.Name = "panelBotton_PBA";
            panelBotton_PBA.Size = new Size(858, 62);
            panelBotton_PBA.TabIndex = 0;
            // 
            // buttonSave_PBA
            // 
            buttonSave_PBA.Enabled = false;
            buttonSave_PBA.FlatStyle = FlatStyle.Flat;
            buttonSave_PBA.Image = Properties.Resources.icon3;
            buttonSave_PBA.Location = new Point(199, 9);
            buttonSave_PBA.Margin = new Padding(3, 2, 3, 2);
            buttonSave_PBA.Name = "buttonSave_PBA";
            buttonSave_PBA.Size = new Size(98, 39);
            buttonSave_PBA.TabIndex = 3;
            toolTipButton_PBA.SetToolTip(buttonSave_PBA, "Сохранить обработанные данные в файл в формате CSV\r\n");
            buttonSave_PBA.UseVisualStyleBackColor = true;
            buttonSave_PBA.Click += buttonSave_MAB_Click;
            buttonSave_PBA.MouseEnter += buttonSave_MAB_MouseEnter;
            // 
            // buttonDone_PBA
            // 
            buttonDone_PBA.Enabled = false;
            buttonDone_PBA.FlatStyle = FlatStyle.Flat;
            buttonDone_PBA.Image = Properties.Resources.icon2;
            buttonDone_PBA.Location = new Point(102, 9);
            buttonDone_PBA.Margin = new Padding(3, 2, 3, 2);
            buttonDone_PBA.Name = "buttonDone_PBA";
            buttonDone_PBA.Size = new Size(91, 39);
            buttonDone_PBA.TabIndex = 2;
            toolTipButton_PBA.SetToolTip(buttonDone_PBA, "Выполнить обработку данных");
            buttonDone_PBA.UseVisualStyleBackColor = true;
            buttonDone_PBA.Click += buttonDone_MAB_Click;
            buttonDone_PBA.MouseEnter += buttonDone_MAB_MouseEnter;
            // 
            // buttonOpen_PBA
            // 
            buttonOpen_PBA.FlatStyle = FlatStyle.Flat;
            buttonOpen_PBA.Image = Properties.Resources.icon1;
            buttonOpen_PBA.Location = new Point(10, 9);
            buttonOpen_PBA.Margin = new Padding(3, 2, 3, 2);
            buttonOpen_PBA.Name = "buttonOpen_PBA";
            buttonOpen_PBA.Size = new Size(87, 39);
            buttonOpen_PBA.TabIndex = 1;
            toolTipButton_PBA.SetToolTip(buttonOpen_PBA, "Открыть файл для обработки данных в формате CSV\r\n");
            buttonOpen_PBA.UseVisualStyleBackColor = true;
            buttonOpen_PBA.Click += buttonOpen_MAB_Click;
            buttonOpen_PBA.MouseDown += buttonOpen_MAB_MouseDown;
            buttonOpen_PBA.MouseEnter += buttonOpen_MAB_MouseEnter;
            // 
            // buttonHelp_PBA
            // 
            buttonHelp_PBA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PBA.FlatStyle = FlatStyle.Flat;
            buttonHelp_PBA.Image = Properties.Resources.icon4;
            buttonHelp_PBA.Location = new Point(766, 9);
            buttonHelp_PBA.Margin = new Padding(3, 2, 3, 2);
            buttonHelp_PBA.Name = "buttonHelp_PBA";
            buttonHelp_PBA.Size = new Size(73, 39);
            buttonHelp_PBA.TabIndex = 0;
            toolTipButton_PBA.SetToolTip(buttonHelp_PBA, "Сведение о программе");
            buttonHelp_PBA.UseVisualStyleBackColor = true;
            buttonHelp_PBA.Click += buttonHelp_MAB_Click;
            buttonHelp_PBA.MouseEnter += buttonHelp_MAB_MouseEnter;
            // 
            // panelTask_PBA
            // 
            panelTask_PBA.Controls.Add(groupBoxTask_PBA);
            panelTask_PBA.Dock = DockStyle.Top;
            panelTask_PBA.Location = new Point(0, 62);
            panelTask_PBA.Margin = new Padding(3, 2, 3, 2);
            panelTask_PBA.Name = "panelTask_PBA";
            panelTask_PBA.Size = new Size(858, 70);
            panelTask_PBA.TabIndex = 1;
            // 
            // groupBoxTask_PBA
            // 
            groupBoxTask_PBA.Controls.Add(pictureBox_PBA);
            groupBoxTask_PBA.Controls.Add(labelTask_PBA);
            groupBoxTask_PBA.Dock = DockStyle.Fill;
            groupBoxTask_PBA.Location = new Point(0, 0);
            groupBoxTask_PBA.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask_PBA.Name = "groupBoxTask_PBA";
            groupBoxTask_PBA.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask_PBA.Size = new Size(858, 70);
            groupBoxTask_PBA.TabIndex = 0;
            groupBoxTask_PBA.TabStop = false;
            groupBoxTask_PBA.Text = "Условие";
            groupBoxTask_PBA.Enter += groupBoxTask_MAB_Enter;
            // 
            // pictureBox_PBA
            // 
            pictureBox_PBA.Image = Properties.Resources.quest;
            pictureBox_PBA.Location = new Point(0, 0);
            pictureBox_PBA.Name = "pictureBox_PBA";
            pictureBox_PBA.Size = new Size(855, 65);
            pictureBox_PBA.TabIndex = 0;
            pictureBox_PBA.TabStop = false;
            // 
            // labelTask_PBA
            // 
            labelTask_PBA.Location = new Point(0, 0);
            labelTask_PBA.Name = "labelTask_PBA";
            labelTask_PBA.Size = new Size(100, 23);
            labelTask_PBA.TabIndex = 1;
            // 
            // panelInputData_PBA
            // 
            panelInputData_PBA.Controls.Add(groupBoxInput_PBA);
            panelInputData_PBA.Dock = DockStyle.Left;
            panelInputData_PBA.Location = new Point(0, 132);
            panelInputData_PBA.Margin = new Padding(3, 2, 3, 2);
            panelInputData_PBA.Name = "panelInputData_PBA";
            panelInputData_PBA.Size = new Size(396, 253);
            panelInputData_PBA.TabIndex = 2;
            // 
            // groupBoxInput_PBA
            // 
            groupBoxInput_PBA.Controls.Add(dataGridViewIn_PBA);
            groupBoxInput_PBA.Dock = DockStyle.Fill;
            groupBoxInput_PBA.Location = new Point(0, 0);
            groupBoxInput_PBA.Margin = new Padding(3, 2, 3, 2);
            groupBoxInput_PBA.Name = "groupBoxInput_PBA";
            groupBoxInput_PBA.Padding = new Padding(3, 2, 3, 2);
            groupBoxInput_PBA.Size = new Size(396, 253);
            groupBoxInput_PBA.TabIndex = 0;
            groupBoxInput_PBA.TabStop = false;
            groupBoxInput_PBA.Text = "Ввод";
            // 
            // dataGridViewIn_PBA
            // 
            dataGridViewIn_PBA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewIn_PBA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_PBA.Dock = DockStyle.Fill;
            dataGridViewIn_PBA.Location = new Point(3, 18);
            dataGridViewIn_PBA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewIn_PBA.Name = "dataGridViewIn_PBA";
            dataGridViewIn_PBA.RowHeadersVisible = false;
            dataGridViewIn_PBA.RowHeadersWidth = 51;
            dataGridViewIn_PBA.ScrollBars = ScrollBars.Horizontal;
            dataGridViewIn_PBA.Size = new Size(390, 233);
            dataGridViewIn_PBA.TabIndex = 0;
            // 
            // panelResult_PBA
            // 
            panelResult_PBA.Controls.Add(groupBoxOutput_PBA);
            panelResult_PBA.Dock = DockStyle.Fill;
            panelResult_PBA.Location = new Point(396, 132);
            panelResult_PBA.Margin = new Padding(3, 2, 3, 2);
            panelResult_PBA.Name = "panelResult_PBA";
            panelResult_PBA.Size = new Size(462, 253);
            panelResult_PBA.TabIndex = 3;
            // 
            // groupBoxOutput_PBA
            // 
            groupBoxOutput_PBA.Controls.Add(dataGridViewOut_PBA);
            groupBoxOutput_PBA.Dock = DockStyle.Fill;
            groupBoxOutput_PBA.Location = new Point(0, 0);
            groupBoxOutput_PBA.Margin = new Padding(3, 2, 3, 2);
            groupBoxOutput_PBA.Name = "groupBoxOutput_PBA";
            groupBoxOutput_PBA.Padding = new Padding(3, 2, 3, 2);
            groupBoxOutput_PBA.Size = new Size(462, 253);
            groupBoxOutput_PBA.TabIndex = 0;
            groupBoxOutput_PBA.TabStop = false;
            groupBoxOutput_PBA.Text = "Вывод";
            // 
            // dataGridViewOut_PBA
            // 
            dataGridViewOut_PBA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewOut_PBA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_PBA.Dock = DockStyle.Fill;
            dataGridViewOut_PBA.Location = new Point(3, 18);
            dataGridViewOut_PBA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewOut_PBA.Name = "dataGridViewOut_PBA";
            dataGridViewOut_PBA.RowHeadersVisible = false;
            dataGridViewOut_PBA.RowHeadersWidth = 51;
            dataGridViewOut_PBA.ScrollBars = ScrollBars.Horizontal;
            dataGridViewOut_PBA.Size = new Size(456, 233);
            dataGridViewOut_PBA.TabIndex = 0;
            // 
            // splitter_PBA
            // 
            splitter_PBA.Location = new Point(396, 132);
            splitter_PBA.Margin = new Padding(3, 2, 3, 2);
            splitter_PBA.Name = "splitter_PBA";
            splitter_PBA.Size = new Size(10, 253);
            splitter_PBA.TabIndex = 4;
            splitter_PBA.TabStop = false;
            // 
            // openFileDialogTask_PBA
            // 
            openFileDialogTask_PBA.FileName = "openFileDialog1";
            // 
            // toolTipButton_PBA
            // 
            toolTipButton_PBA.IsBalloon = true;
            toolTipButton_PBA.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_PBA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 385);
            Controls.Add(splitter_PBA);
            Controls.Add(panelResult_PBA);
            Controls.Add(panelInputData_PBA);
            Controls.Add(panelTask_PBA);
            Controls.Add(panelBotton_PBA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 10 | Плесовских Б. А.";
            Load += FormMain_Load;
            panelBotton_PBA.ResumeLayout(false);
            panelTask_PBA.ResumeLayout(false);
            groupBoxTask_PBA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_PBA).EndInit();
            panelInputData_PBA.ResumeLayout(false);
            groupBoxInput_PBA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PBA).EndInit();
            panelResult_PBA.ResumeLayout(false);
            groupBoxOutput_PBA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PBA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotton_PBA;
        private Panel panelTask_PBA;
        private Panel panelInputData_PBA;
        private Panel panelResult_PBA;
        private Splitter splitter_PBA;
        private Button buttonSave_PBA;
        private Button buttonDone_PBA;
        private Button buttonOpen_PBA;
        private Button buttonHelp_PBA;
        private OpenFileDialog openFileDialogTask_PBA;
        private ToolTip toolTipButton_PBA;
        private GroupBox groupBoxTask_PBA;
        private Label labelTask_PBA;
        private GroupBox groupBoxInput_PBA;
        private GroupBox groupBoxOutput_PBA;
        private DataGridView dataGridViewIn_PBA;
        private DataGridView dataGridViewOut_PBA;
        private SaveFileDialog saveFileDialogMatrix_PBA;
        private PictureBox pictureBox_PBA;
    }
}
