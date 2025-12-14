using Tyuiu.PlesovskikhBA.Sprint6.Task1.V16.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint6.Task1.V16
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
            buttonHelpClick_PBA = new Button();
            textBoxone_PBA = new TextBox();
            textBoxResult_PBA = new TextBox();
            groupBoxTask_PBA = new GroupBox();
            pictureBox1_PBA = new PictureBox();
            textBoxR_PBA = new TextBox();
            buttonStrt_PBA = new Button();
            groupBox1_PBA = new GroupBox();
            textBoxstrtshaga_PBA = new TextBox();
            textBoxtwo_PBA = new TextBox();
            textBoxkon_PBA = new TextBox();
            groupBoxviv_PBA = new GroupBox();
            groupBoxTask_PBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_PBA).BeginInit();
            groupBox1_PBA.SuspendLayout();
            groupBoxviv_PBA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelpClick_PBA
            // 
            buttonHelpClick_PBA.BackColor = SystemColors.ControlDark;
            buttonHelpClick_PBA.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_PBA.Location = new Point(476, 473);
            buttonHelpClick_PBA.Margin = new Padding(3, 2, 3, 2);
            buttonHelpClick_PBA.Name = "buttonHelpClick_PBA";
            buttonHelpClick_PBA.Size = new Size(88, 56);
            buttonHelpClick_PBA.TabIndex = 14;
            buttonHelpClick_PBA.Text = "?";
            buttonHelpClick_PBA.UseVisualStyleBackColor = false;
            buttonHelpClick_PBA.Click += buttonHelpClick_tia_Click;
            // 
            // textBoxone_PBA
            // 
            textBoxone_PBA.Location = new Point(5, 89);
            textBoxone_PBA.Margin = new Padding(3, 2, 3, 2);
            textBoxone_PBA.Name = "textBoxone_PBA";
            textBoxone_PBA.Size = new Size(129, 23);
            textBoxone_PBA.TabIndex = 13;
            // 
            // textBoxResult_PBA
            // 
            textBoxResult_PBA.Location = new Point(0, 0);
            textBoxResult_PBA.Name = "textBoxResult_PBA";
            textBoxResult_PBA.Size = new Size(100, 23);
            textBoxResult_PBA.TabIndex = 0;
            // 
            // groupBoxTask_PBA
            // 
            groupBoxTask_PBA.Controls.Add(pictureBox1_PBA);
            groupBoxTask_PBA.Location = new Point(10, 9);
            groupBoxTask_PBA.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask_PBA.Name = "groupBoxTask_PBA";
            groupBoxTask_PBA.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask_PBA.Size = new Size(654, 396);
            groupBoxTask_PBA.TabIndex = 11;
            groupBoxTask_PBA.TabStop = false;
            groupBoxTask_PBA.Text = "Условия";
            // 
            // pictureBox1_PBA
            // 
            pictureBox1_PBA.Location = new Point(20, 29);
            pictureBox1_PBA.Margin = new Padding(3, 2, 3, 2);
            pictureBox1_PBA.Name = "pictureBox1_PBA";
            pictureBox1_PBA.Size = new Size(561, 161);
            pictureBox1_PBA.TabIndex = 1;
            pictureBox1_PBA.TabStop = false;
            // 
            // textBoxR_PBA
            // 
            textBoxR_PBA.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxR_PBA.Location = new Point(37, 29);
            textBoxR_PBA.Margin = new Padding(3, 2, 3, 2);
            textBoxR_PBA.Multiline = true;
            textBoxR_PBA.Name = "textBoxR_PBA";
            textBoxR_PBA.ReadOnly = true;
            textBoxR_PBA.ScrollBars = ScrollBars.Vertical;
            textBoxR_PBA.Size = new Size(324, 457);
            textBoxR_PBA.TabIndex = 18;
            textBoxR_PBA.TextChanged += textBoxResult_tia_TextChanged;
            // 
            // buttonStrt_PBA
            // 
            buttonStrt_PBA.BackColor = SystemColors.ActiveCaption;
            buttonStrt_PBA.Location = new Point(592, 472);
            buttonStrt_PBA.Margin = new Padding(3, 2, 3, 2);
            buttonStrt_PBA.Name = "buttonStrt_PBA";
            buttonStrt_PBA.Size = new Size(136, 58);
            buttonStrt_PBA.TabIndex = 10;
            buttonStrt_PBA.Text = "Выполнить";
            buttonStrt_PBA.UseVisualStyleBackColor = false;
            buttonStrt_PBA.Click += buttonStrt_tia_Click;
            // 
            // groupBox1_PBA
            // 
            groupBox1_PBA.Controls.Add(textBoxstrtshaga_PBA);
            groupBox1_PBA.Controls.Add(textBoxtwo_PBA);
            groupBox1_PBA.Controls.Add(textBoxkon_PBA);
            groupBox1_PBA.Controls.Add(textBoxone_PBA);
            groupBox1_PBA.Location = new Point(25, 410);
            groupBox1_PBA.Margin = new Padding(3, 2, 3, 2);
            groupBox1_PBA.Name = "groupBox1_PBA";
            groupBox1_PBA.Padding = new Padding(3, 2, 3, 2);
            groupBox1_PBA.Size = new Size(428, 120);
            groupBox1_PBA.TabIndex = 17;
            groupBox1_PBA.TabStop = false;
            groupBox1_PBA.Text = "Ввод данных";
            // 
            // textBoxstrtshaga_PBA
            // 
            textBoxstrtshaga_PBA.Location = new Point(5, 64);
            textBoxstrtshaga_PBA.Margin = new Padding(3, 2, 3, 2);
            textBoxstrtshaga_PBA.Name = "textBoxstrtshaga_PBA";
            textBoxstrtshaga_PBA.ReadOnly = true;
            textBoxstrtshaga_PBA.Size = new Size(129, 23);
            textBoxstrtshaga_PBA.TabIndex = 19;
            textBoxstrtshaga_PBA.Text = "Начало шага";
            // 
            // textBoxtwo_PBA
            // 
            textBoxtwo_PBA.Location = new Point(164, 89);
            textBoxtwo_PBA.Margin = new Padding(3, 2, 3, 2);
            textBoxtwo_PBA.Name = "textBoxtwo_PBA";
            textBoxtwo_PBA.Size = new Size(129, 23);
            textBoxtwo_PBA.TabIndex = 18;
            textBoxtwo_PBA.KeyPress += textBoxtwo_tia_KeyPress;
            // 
            // textBoxkon_PBA
            // 
            textBoxkon_PBA.Location = new Point(164, 62);
            textBoxkon_PBA.Margin = new Padding(3, 2, 3, 2);
            textBoxkon_PBA.Name = "textBoxkon_PBA";
            textBoxkon_PBA.ReadOnly = true;
            textBoxkon_PBA.Size = new Size(129, 23);
            textBoxkon_PBA.TabIndex = 17;
            textBoxkon_PBA.Text = "Конец шага";
            // 
            // groupBoxviv_PBA
            // 
            groupBoxviv_PBA.Controls.Add(textBoxR_PBA);
            groupBoxviv_PBA.Location = new Point(753, 9);
            groupBoxviv_PBA.Margin = new Padding(3, 2, 3, 2);
            groupBoxviv_PBA.Name = "groupBoxviv_PBA";
            groupBoxviv_PBA.Padding = new Padding(3, 2, 3, 2);
            groupBoxviv_PBA.Size = new Size(454, 520);
            groupBoxviv_PBA.TabIndex = 19;
            groupBoxviv_PBA.TabStop = false;
            groupBoxviv_PBA.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 555);
            Controls.Add(groupBoxviv_PBA);
            Controls.Add(groupBox1_PBA);
            Controls.Add(buttonHelpClick_PBA);
            Controls.Add(groupBoxTask_PBA);
            Controls.Add(buttonStrt_PBA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 16 | Плесовских Б. А.";
            Load += FormMain_Load;
            groupBoxTask_PBA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1_PBA).EndInit();
            groupBox1_PBA.ResumeLayout(false);
            groupBox1_PBA.PerformLayout();
            groupBoxviv_PBA.ResumeLayout(false);
            groupBoxviv_PBA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonHelpClick_PBA;
        private TextBox textBoxone_PBA;
        private TextBox textBoxResult_PBA;
        private GroupBox groupBoxTask_PBA;
        private PictureBox pictureBox1_PBA;
        private Button buttonStrt_PBA;
        private GroupBox groupBox1_PBA;
        private TextBox textBoxkon_PBA;
        private TextBox textBoxtwo_PBA;
        private TextBox textBoxstrtshaga_PBA;
        private TextBox textBoxR_PBA;
        private GroupBox groupBoxviv_PBA;
    }
}