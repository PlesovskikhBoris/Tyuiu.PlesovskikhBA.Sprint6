using Tyuiu.PlesovskikhBA.Sprint6.Task7.V10.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_PBA.Filter = "Значения , разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_PBA.Filter = "Значения , разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService dataService = new DataService();
        static int rows;
        static int columns;
        static string? openFilePath;
        private void buttonOpen_MAB_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonOpen_MAB_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PBA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MAB_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PBA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MAB_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PBA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_MAB_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PBA.ToolTipTitle = "Справка";
        }

        private void buttonHelp_MAB_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_MAB_Click(object sender, EventArgs e)
        {
            int[,] values = dataService.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_PBA.Rows[i].Cells[j].Value = values[i, j];
                }
            }
            buttonSave_PBA.Enabled = true;
        }

        private void buttonSave_MAB_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PBA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PBA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PBA.ShowDialog();

            string path = saveFileDialogMatrix_PBA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_PBA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_PBA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpen_MAB_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PBA.ShowDialog();
            openFilePath = openFileDialogTask_PBA.FileName;

            if (openFilePath != null)
            {
                int[,] arrayValues = dataService.GetMatrix(openFilePath);

                rows = arrayValues.GetLength(0);
                columns = arrayValues.GetLength(1);

                dataGridViewIn_PBA.ColumnCount = columns;
                dataGridViewIn_PBA.RowCount = rows;
                dataGridViewOut_PBA.ColumnCount = columns;
                dataGridViewOut_PBA.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn_PBA.Columns[i].Width = 25;
                    dataGridViewOut_PBA.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewIn_PBA.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }

                buttonDone_PBA.Enabled = true;
            }
        }

        private void groupBoxTask_MAB_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxTask_PBA_Click(object sender, EventArgs e)
        {

        }
    }
}
