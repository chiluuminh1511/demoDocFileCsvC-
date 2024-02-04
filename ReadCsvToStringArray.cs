using System;
using System.IO;

namespace ReadCsvToStringArray
{
    class Program
    {
        static string[,] Main(string fileName)
        {
            // Đọc file CSV
            string[] lines = File.ReadAllLines(fileName);

            // Tạo mảng hai chiều
            string[,] array = new string[lines.Length, lines[0].Split(',').Length];

            // Duyệt qua từng dòng trong file CSV
            for (int i = 0; i < lines.Length; i++)
            {
                // Tách các giá trị trong dòng thành mảng một chiều
                string[] columns = lines[i].Split(',');

                // Duyệt qua từng giá trị trong mảng một chiều
                for (int j = 0; j < columns.Length; j++)
                {
                    // Lưu giá trị vào mảng hai chiều
                    array[i, j] = columns[j].Trim();
                }
            }

            // Trả về mảng hai chiều
            return array;
        }

        // static void Main(string[] args)
        // {
        //     // Gọi hàm ReadCsvToStringArray
        //     string[,] array = ReadCsvToStringArray("Dai.csv");

        //     // In mảng hai chiều ra console
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             Console.Write(array[i, j] + " ");
        //         }

        //         Console.WriteLine();
        //     }
        // }
    }
}
