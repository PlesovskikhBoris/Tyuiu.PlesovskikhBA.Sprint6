namespace Tyuiu.PlesovskikhBA.Sprint6.Task7.V10
{
    partial class FormAbout
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
            pictureBoxAvatar_MAB = new PictureBox();
            labelInfo_MAB = new Label();
            buttonOK_MAB = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MAB).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_MAB
            // 
            pictureBoxAvatar_MAB.Image = Properties.Resources.Boris;
            pictureBoxAvatar_MAB.Location = new Point(10, 16);
            pictureBoxAvatar_MAB.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAvatar_MAB.Name = "pictureBoxAvatar_MAB";
            pictureBoxAvatar_MAB.Size = new Size(151, 174);
            pictureBoxAvatar_MAB.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_MAB.TabIndex = 0;
            pictureBoxAvatar_MAB.TabStop = false;
            // 
            // labelInfo_MAB
            // 
            labelInfo_MAB.AutoSize = true;
            labelInfo_MAB.Location = new Point(167, 26);
            labelInfo_MAB.Name = "labelInfo_MAB";
            labelInfo_MAB.Size = new Size(284, 15);
            labelInfo_MAB.TabIndex = 1;
            labelInfo_MAB.Text = "Выполнил таск 7 Плесовских Борис СМАРТб-24-1";
            // 
            // buttonOK_MAB
            // 
            buttonOK_MAB.Location = new Point(374, 178);
            buttonOK_MAB.Margin = new Padding(3, 2, 3, 2);
            buttonOK_MAB.Name = "buttonOK_MAB";
            buttonOK_MAB.Size = new Size(127, 38);
            buttonOK_MAB.TabIndex = 2;
            buttonOK_MAB.Text = "OK";
            buttonOK_MAB.UseVisualStyleBackColor = true;
            buttonOK_MAB.Click += buttonOK_MAB_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 225);
            Controls.Add(buttonOK_MAB);
            Controls.Add(labelInfo_MAB);
            Controls.Add(pictureBoxAvatar_MAB);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MAB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_MAB;
        private Label labelInfo_MAB;
        private Button buttonOK_MAB;
    }
}