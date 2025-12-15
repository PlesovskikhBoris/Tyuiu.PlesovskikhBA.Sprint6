using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PlesovskikhBA.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {

        public int[,] GetMatrix(string path)
        {
            string[] file = File.ReadAllText(path).Split('\n');
            string[] cs = file[4].Split(';');
            int[,] m = new int[file.Length, file[0].Split(';').Length];
            for (int i = 0; i < file[0].Split(';').Length; i++)
            {
                string a = file[4].Split(';')[i];
                string[] b = file[4].Split(';');
                int c = int.Parse(a);
                if (int.Parse(cs[i]) <= 10 && int.Parse(cs[i]) >= 5) { cs[i] = "0"; }
                ;
            }
            file[4] = string.Join(';', cs);
            for (int i = 0; i < file[0].Split(';').Length; i++)
            {
                for (int j = 0; j < file.Length; j++)
                {
                    m[i, j] = int.Parse(file[i].Split(';')[j]);
                }
            }
            return m;
        }
    }
}