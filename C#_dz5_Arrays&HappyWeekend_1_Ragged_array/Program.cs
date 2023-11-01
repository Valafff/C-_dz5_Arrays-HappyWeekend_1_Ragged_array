#define Ragged_array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__dz5_Arrays_HappyWeekend_1_Ragged_array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Random rand = new Random(0);

#if Ragged_array

			int lenght_mas = 0, min = 0, max = 0, summ = 0; ;
			int[][] arr =
			{
				new int[]{3,5,8,13,21},
				new int[]{34,55,89},
				new int[]{144,233,377,610}
			};

            //Вывод исходного зубчатого массива
            Console.WriteLine("Вывод исходного зубчатого массива:");
            for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.Write(arr[i][j] + "\t");
				}
				Console.WriteLine();
			}

			//Количество элементов
			for (int i = 0; i < arr.Length; i++)//количество элементов
			{
				lenght_mas += arr[i].Length;
			}
			Console.WriteLine("\nКоличество элементов в зубчатом массиве: "+ lenght_mas);

			//Сумма элементов
			for (int i = 0; i < arr.Length; i++)
			{
				summ += arr[i].Sum();
			}
			Console.WriteLine("\nСумма элементов зубчатого массива: " + summ);

			//Среднее арифметическое 
			Console.WriteLine("\nСреднее арифметическое элементов зубчатого массива: " + (double)summ/lenght_mas);

			//Максимальное и минимальное значение
			min = arr[0].Min();
			max = arr[0].Max();

			for (int i = 0; i < arr.Length; i++)//мин и макс
			{
				if (arr[i].Min() < min)
				{
					min = arr[i].Min();
				}
				if (arr[i].Max() > max)
				{
					max = arr[i].Max();
				}
			}
			Console.WriteLine("\nМинимальное значение элементов зубчатого массива:" + min);
			Console.WriteLine("Максимальное значение элементов зубчатого массива:" + max);


#endif



		}
	}
}
