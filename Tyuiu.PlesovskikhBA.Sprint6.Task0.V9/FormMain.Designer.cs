using Tyuiu.PlesovskikhBA.Sprint6.Task0.V9.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint6.Task0.V9
{
    partial class FormMain
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
            groupBoxTask_PBA = new GroupBox();
            textBoxTask_PBA = new TextBox();
            pictureBoxFormula_PBA = new PictureBox();
            groupBoxInPutData_PBA = new GroupBox();
            labelX_PBA = new Label();
            textBoxX_PBA = new TextBox();
            groupBoxOutPutData_PBA = new GroupBox();
            labelRes_PBA = new Label();
            textBoxRes_PBA = new TextBox();
            buttonDone_PBA = new Button();
            buttonHelp_PBA = new Button();
            groupBoxTask_PBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PBA).BeginInit();
            groupBoxInPutData_PBA.SuspendLayout();
            groupBoxOutPutData_PBA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_PBA
            // 
            groupBoxTask_PBA.Controls.Add(textBoxTask_PBA);
            groupBoxTask_PBA.Controls.Add(pictureBoxFormula_PBA);
            groupBoxTask_PBA.Location = new Point(14, 24);
            groupBoxTask_PBA.Name = "groupBoxTask_PBA";
            groupBoxTask_PBA.Size = new Size(531, 213);
            groupBoxTask_PBA.TabIndex = 0;
            groupBoxTask_PBA.TabStop = false;
            groupBoxTask_PBA.Text = "Условие";
            groupBoxTask_PBA.Enter += groupBoxCond_Enter;
            // 
            // textBoxTask_PBA
            // 
            textBoxTask_PBA.BorderStyle = BorderStyle.None;
            textBoxTask_PBA.Location = new Point(7, 22);
            textBoxTask_PBA.Multiline = true;
            textBoxTask_PBA.Name = "textBoxTask_PBA";
            textBoxTask_PBA.ReadOnly = true;
            textBoxTask_PBA.Size = new Size(425, 185);
            textBoxTask_PBA.TabIndex = 2;
            textBoxTask_PBA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_PBA
            // 
            pictureBoxFormula_PBA.Image = Properties.Resources.formula;
            pictureBoxFormula_PBA.Location = new Point(439, 22);
            pictureBoxFormula_PBA.Name = "pictureBoxFormula_PBA";
            pictureBoxFormula_PBA.Size = new Size(84, 50);
            pictureBoxFormula_PBA.TabIndex = 0;
            pictureBoxFormula_PBA.TabStop = false;
            pictureBoxFormula_PBA.Click += pictureBoxFormula_SAA_Click;
            // 
            // groupBoxInPutData_PBA
            // 
            groupBoxInPutData_PBA.Controls.Add(labelX_PBA);
            groupBoxInPutData_PBA.Controls.Add(textBoxX_PBA);
            groupBoxInPutData_PBA.Location = new Point(14, 245);
            groupBoxInPutData_PBA.Name = "groupBoxInPutData_PBA";
            groupBoxInPutData_PBA.Size = new Size(233, 70);
            groupBoxInPutData_PBA.TabIndex = 1;
            groupBoxInPutData_PBA.TabStop = false;
            groupBoxInPutData_PBA.Text = "Ввод данных";
            groupBoxInPutData_PBA.Enter += groupBoxInPutData_SAA_Enter;
            // 
            // labelX_PBA
            // 
            labelX_PBA.AutoSize = true;
            labelX_PBA.Location = new Point(8, 18);
            labelX_PBA.Name = "labelX_PBA";
            labelX_PBA.Size = new Size(89, 15);
            labelX_PBA.TabIndex = 1;
            labelX_PBA.Text = "Переменная X:";
            // 
            // textBoxX_PBA
            // 
            textBoxX_PBA.Location = new Point(7, 37);
            textBoxX_PBA.Name = "textBoxX_PBA";
            textBoxX_PBA.Size = new Size(116, 23);
            textBoxX_PBA.TabIndex = 0;
            textBoxX_PBA.TextChanged += textBoxX_SAA_TextChanged;
            textBoxX_PBA.KeyPress += textBoxX_SAA_KeyPress;
            // 
            // groupBoxOutPutData_PBA
            // 
            groupBoxOutPutData_PBA.Controls.Add(labelRes_PBA);
            groupBoxOutPutData_PBA.Controls.Add(textBoxRes_PBA);
            groupBoxOutPutData_PBA.Location = new Point(274, 245);
            groupBoxOutPutData_PBA.Name = "groupBoxOutPutData_PBA";
            groupBoxOutPutData_PBA.Size = new Size(264, 70);
            groupBoxOutPutData_PBA.TabIndex = 2;
            groupBoxOutPutData_PBA.TabStop = false;
            groupBoxOutPutData_PBA.Text = "Вывод данных";
            // 
            // labelRes_PBA
            // 
            labelRes_PBA.AutoSize = true;
            labelRes_PBA.Location = new Point(7, 18);
            labelRes_PBA.Name = "labelRes_PBA";
            labelRes_PBA.Size = new Size(63, 15);
            labelRes_PBA.TabIndex = 1;
            labelRes_PBA.Text = "Результат:";
            // 
            // textBoxRes_PBA
            // 
            textBoxRes_PBA.Location = new Point(11, 37);
            textBoxRes_PBA.Name = "textBoxRes_PBA";
            textBoxRes_PBA.ReadOnly = true;
            textBoxRes_PBA.Size = new Size(215, 23);
            textBoxRes_PBA.TabIndex = 0;
            textBoxRes_PBA.TextChanged += textBox2_TextChanged;
            // 
            // buttonDone_PBA
            // 
            buttonDone_PBA.Location = new Point(338, 322);
            buttonDone_PBA.Name = "buttonDone_PBA";
            buttonDone_PBA.Size = new Size(199, 38);
            buttonDone_PBA.TabIndex = 3;
            buttonDone_PBA.Text = "Выполнить";
            buttonDone_PBA.UseVisualStyleBackColor = true;
            buttonDone_PBA.Click += buttonDone_SAA_Click;
            // 
            // buttonHelp_PBA
            // 
            buttonHelp_PBA.FlatStyle = FlatStyle.Flat;
            buttonHelp_PBA.Location = new Point(274, 322);
            buttonHelp_PBA.Name = "buttonHelp_PBA";
            buttonHelp_PBA.Size = new Size(57, 38);
            buttonHelp_PBA.TabIndex = 4;
            buttonHelp_PBA.Text = "?";
            buttonHelp_PBA.UseVisualStyleBackColor = true;
            buttonHelp_PBA.Click += buttonHelp_SAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 374);
            Controls.Add(buttonHelp_PBA);
            Controls.Add(buttonDone_PBA);
            Controls.Add(groupBoxOutPutData_PBA);
            Controls.Add(groupBoxInPutData_PBA);
            Controls.Add(groupBoxTask_PBA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 9 | Плесовских Б. А.";
            groupBoxTask_PBA.ResumeLayout(false);
            groupBoxTask_PBA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PBA).EndInit();
            groupBoxInPutData_PBA.ResumeLayout(false);
            groupBoxInPutData_PBA.PerformLayout();
            groupBoxOutPutData_PBA.ResumeLayout(false);
            groupBoxOutPutData_PBA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PBA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PBA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_PBA;
        private System.Windows.Forms.TextBox textBoxX_PBA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_PBA;
        private System.Windows.Forms.Label labelRes_PBA;
        private System.Windows.Forms.TextBox textBoxRes_PBA;
        private System.Windows.Forms.Label labelX_PBA;
        private System.Windows.Forms.Button buttonDone_PBA;
        private System.Windows.Forms.Button buttonHelp_PBA;
        private System.Windows.Forms.TextBox textBoxTask_PBA;
    }
}