// int stepen(int a, int b)
// {
//   int c = a;
//   for (int i = 0; i < b - 1; i++)
//   {
//     c *= a;
//   }
//   return c;
// }

// Console.WriteLine(stepen(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));



// int calculate_sum_cifr(int a)
// {   
//     int suma = 0;
//     while (a > 0)
//     {
//         suma += a % 10;
//         a /= 10;
//     }
//     return suma;
// }

// Console.WriteLine(calculate_sum_cifr(Convert.ToInt32(Console.ReadLine())));




// int[] GetArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = new Random().Next(2, 1000);
//     }
//     return array;
// }


// Console.WriteLine(String.Join('\t', GetArray()));