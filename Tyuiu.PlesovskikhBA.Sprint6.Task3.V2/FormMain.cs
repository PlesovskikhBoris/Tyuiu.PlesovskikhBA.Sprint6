using Tyuiu.PlesovskikhBA.Sprint6.Task3.V2.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = new int[5, 5] {
                    { -12, -4, -20, 5, -5 },
                    { 2, 15, 1, -20, 7 },
                    { 15, -15, 2, 11, 5 },
                    { -19, -9, 16, 0, 1 },
                    { 17, 16, 5, 12, -8 }
                };

                int[,] resultMatrix = ds.Calculate(matrix);

                dataGridViewResult_PBA.ColumnCount = 5;
                dataGridViewResult_PBA.RowCount = 5;
                dataGridViewResult_PBA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < 5; i++)
                {
                    dataGridViewResult_PBA.Columns[i].HeaderText = $"Столбец {i + 1}";
                }

                for (int i = 0; i < 5; i++)
                {
                    dataGridViewResult_PBA.Rows[i].HeaderCell.Value = $"Столбец {i + 1}";
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewResult_PBA.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }

                dataGridViewResult_PBA.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 | Спринт 6 | Вариант 2 | Выполнил студент Плесовских Борис Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
