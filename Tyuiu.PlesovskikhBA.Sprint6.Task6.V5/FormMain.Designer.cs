namespace Tyuiu.PlesovskikhBA.Sprint6.Task6.V5
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
            panelButtons_PDA = new Panel();
            buttonQuestion_PDA = new Button();
            buttonDown_PDA = new Button();
            buttonOpen_PDA = new Button();
            panelCond_PDA = new Panel();
            groupBoxCond_PDA = new GroupBox();
            textBoxConditions_PDA = new TextBox();
            panelIP_PDA = new Panel();
            groupBoxIP_PDA = new GroupBox();
            textBoxInPut_PDA = new TextBox();
            panelOP_PDA = new Panel();
            groupBoxOP_PDA = new GroupBox();
            textBoxOutPut_PDA = new TextBox();
            openFileDialog_PDA = new OpenFileDialog();
            toolTip_PDA = new ToolTip(components);
            panelButtons_PDA.SuspendLayout();
            panelCond_PDA.SuspendLayout();
            groupBoxCond_PDA.SuspendLayout();
            panelIP_PDA.SuspendLayout();
            groupBoxIP_PDA.SuspendLayout();
            panelOP_PDA.SuspendLayout();
            groupBoxOP_PDA.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_PDA
            // 
            panelButtons_PDA.Controls.Add(buttonQuestion_PDA);
            panelButtons_PDA.Controls.Add(buttonDown_PDA);
            panelButtons_PDA.Controls.Add(buttonOpen_PDA);
            panelButtons_PDA.Dock = DockStyle.Top;
            panelButtons_PDA.Location = new Point(0, 0);
            panelButtons_PDA.Margin = new Padding(3, 2, 3, 2);
            panelButtons_PDA.Name = "panelButtons_PDA";
            panelButtons_PDA.Size = new Size(700, 52);
            panelButtons_PDA.TabIndex = 0;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.Image = Properties.Resources.icon3;
            buttonQuestion_PDA.Location = new Point(640, 9);
            buttonQuestion_PDA.Margin = new Padding(3, 2, 3, 2);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(49, 39);
            buttonQuestion_PDA.TabIndex = 2;
            buttonQuestion_PDA.UseVisualStyleBackColor = true;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // buttonDown_PDA
            // 
            buttonDown_PDA.Image = Properties.Resources.icon2;
            buttonDown_PDA.Location = new Point(66, 9);
            buttonDown_PDA.Margin = new Padding(3, 2, 3, 2);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(46, 39);
            buttonDown_PDA.TabIndex = 1;
            buttonDown_PDA.UseVisualStyleBackColor = true;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // buttonOpen_PDA
            // 
            buttonOpen_PDA.Image = Properties.Resources.icon1;
            buttonOpen_PDA.Location = new Point(10, 9);
            buttonOpen_PDA.Margin = new Padding(3, 2, 3, 2);
            buttonOpen_PDA.Name = "buttonOpen_PDA";
            buttonOpen_PDA.Size = new Size(51, 39);
            buttonOpen_PDA.TabIndex = 0;
            toolTip_PDA.SetToolTip(buttonOpen_PDA, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_PDA.UseVisualStyleBackColor = true;
            buttonOpen_PDA.Click += buttonOpen_PDA_Click;
            // 
            // panelCond_PDA
            // 
            panelCond_PDA.Controls.Add(groupBoxCond_PDA);
            panelCond_PDA.Dock = DockStyle.Top;
            panelCond_PDA.Location = new Point(0, 52);
            panelCond_PDA.Margin = new Padding(3, 2, 3, 2);
            panelCond_PDA.Name = "panelCond_PDA";
            panelCond_PDA.Size = new Size(700, 56);
            panelCond_PDA.TabIndex = 1;
            // 
            // groupBoxCond_PDA
            // 
            groupBoxCond_PDA.Controls.Add(textBoxConditions_PDA);
            groupBoxCond_PDA.Dock = DockStyle.Fill;
            groupBoxCond_PDA.Location = new Point(0, 0);
            groupBoxCond_PDA.Margin = new Padding(3, 2, 3, 2);
            groupBoxCond_PDA.Name = "groupBoxCond_PDA";
            groupBoxCond_PDA.Padding = new Padding(3, 2, 3, 2);
            groupBoxCond_PDA.Size = new Size(700, 56);
            groupBoxCond_PDA.TabIndex = 0;
            groupBoxCond_PDA.TabStop = false;
            groupBoxCond_PDA.Text = "Условие";
            // 
            // textBoxConditions_PDA
            // 
            textBoxConditions_PDA.Dock = DockStyle.Fill;
            textBoxConditions_PDA.Location = new Point(3, 18);
            textBoxConditions_PDA.Margin = new Padding(3, 2, 3, 2);
            textBoxConditions_PDA.Multiline = true;
            textBoxConditions_PDA.Name = "textBoxConditions_PDA";
            textBoxConditions_PDA.ReadOnly = true;
            textBoxConditions_PDA.Size = new Size(694, 36);
            textBoxConditions_PDA.TabIndex = 0;
            textBoxConditions_PDA.Text = "Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается I в результирующею строку и вывести ее в textBoxOut.";
            // 
            // panelIP_PDA
            // 
            panelIP_PDA.Controls.Add(groupBoxIP_PDA);
            panelIP_PDA.Dock = DockStyle.Left;
            panelIP_PDA.Location = new Point(0, 108);
            panelIP_PDA.Margin = new Padding(3, 2, 3, 2);
            panelIP_PDA.Name = "panelIP_PDA";
            panelIP_PDA.Size = new Size(289, 230);
            panelIP_PDA.TabIndex = 2;
            // 
            // groupBoxIP_PDA
            // 
            groupBoxIP_PDA.Controls.Add(textBoxInPut_PDA);
            groupBoxIP_PDA.Dock = DockStyle.Fill;
            groupBoxIP_PDA.Location = new Point(0, 0);
            groupBoxIP_PDA.Margin = new Padding(3, 2, 3, 2);
            groupBoxIP_PDA.Name = "groupBoxIP_PDA";
            groupBoxIP_PDA.Padding = new Padding(3, 2, 3, 2);
            groupBoxIP_PDA.Size = new Size(289, 230);
            groupBoxIP_PDA.TabIndex = 0;
            groupBoxIP_PDA.TabStop = false;
            groupBoxIP_PDA.Text = "Ввод данных:";
            // 
            // textBoxInPut_PDA
            // 
            textBoxInPut_PDA.Dock = DockStyle.Fill;
            textBoxInPut_PDA.Location = new Point(3, 18);
            textBoxInPut_PDA.Margin = new Padding(3, 2, 3, 2);
            textBoxInPut_PDA.Multiline = true;
            textBoxInPut_PDA.Name = "textBoxInPut_PDA";
            textBoxInPut_PDA.ReadOnly = true;
            textBoxInPut_PDA.ScrollBars = ScrollBars.Vertical;
            textBoxInPut_PDA.Size = new Size(283, 210);
            textBoxInPut_PDA.TabIndex = 0;
            // 
            // panelOP_PDA
            // 
            panelOP_PDA.Controls.Add(groupBoxOP_PDA);
            panelOP_PDA.Dock = DockStyle.Fill;
            panelOP_PDA.Location = new Point(289, 108);
            panelOP_PDA.Margin = new Padding(3, 2, 3, 2);
            panelOP_PDA.Name = "panelOP_PDA";
            panelOP_PDA.Size = new Size(411, 230);
            panelOP_PDA.TabIndex = 3;
            // 
            // groupBoxOP_PDA
            // 
            groupBoxOP_PDA.Controls.Add(textBoxOutPut_PDA);
            groupBoxOP_PDA.Dock = DockStyle.Fill;
            groupBoxOP_PDA.Location = new Point(0, 0);
            groupBoxOP_PDA.Margin = new Padding(3, 2, 3, 2);
            groupBoxOP_PDA.Name = "groupBoxOP_PDA";
            groupBoxOP_PDA.Padding = new Padding(3, 2, 3, 2);
            groupBoxOP_PDA.Size = new Size(411, 230);
            groupBoxOP_PDA.TabIndex = 0;
            groupBoxOP_PDA.TabStop = false;
            groupBoxOP_PDA.Text = "Вывод данных:";
            // 
            // textBoxOutPut_PDA
            // 
            textBoxOutPut_PDA.Dock = DockStyle.Fill;
            textBoxOutPut_PDA.Location = new Point(3, 18);
            textBoxOutPut_PDA.Margin = new Padding(3, 2, 3, 2);
            textBoxOutPut_PDA.Multiline = true;
            textBoxOutPut_PDA.Name = "textBoxOutPut_PDA";
            textBoxOutPut_PDA.ReadOnly = true;
            textBoxOutPut_PDA.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_PDA.Size = new Size(405, 210);
            textBoxOutPut_PDA.TabIndex = 0;
            // 
            // openFileDialog_PDA
            // 
            openFileDialog_PDA.FileName = "openFileDialog1";
            // 
            // toolTip_PDA
            // 
            toolTip_PDA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_PDA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panelOP_PDA);
            Controls.Add(panelIP_PDA);
            Controls.Add(panelCond_PDA);
            Controls.Add(panelButtons_PDA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6  | Таск 6 | Вариант 5 | Пузина Д. А.";
            panelButtons_PDA.ResumeLayout(false);
            panelCond_PDA.ResumeLayout(false);
            groupBoxCond_PDA.ResumeLayout(false);
            groupBoxCond_PDA.PerformLayout();
            panelIP_PDA.ResumeLayout(false);
            groupBoxIP_PDA.ResumeLayout(false);
            groupBoxIP_PDA.PerformLayout();
            panelOP_PDA.ResumeLayout(false);
            groupBoxOP_PDA.ResumeLayout(false);
            groupBoxOP_PDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_PDA;
        private Panel panelCond_PDA;
        private GroupBox groupBoxCond_PDA;
        private Panel panelIP_PDA;
        private GroupBox groupBoxIP_PDA;
        private Panel panelOP_PDA;
        private GroupBox groupBoxOP_PDA;
        private Button buttonDown_PDA;
        private Button buttonOpen_PDA;
        private TextBox textBoxConditions_PDA;
        private OpenFileDialog openFileDialog_PDA;
        private ToolTip toolTip_PDA;
        private Button buttonQuestion_PDA;
        private TextBox textBoxInPut_PDA;
        private TextBox textBoxOutPut_PDA;
    }
}