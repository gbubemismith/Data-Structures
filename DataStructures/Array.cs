// using System;

// namespace DataStructures
// {
//     public class Array
//     {
//         private int[] items;
//         private int count;
//         public Array(int length)
//         {
//             items = new int[length];
//         }

//         public void Print()
//         {
//             for (int i = 0; i < count; i++)
//                 Console.WriteLine(items[i]);
//         }

//         public void Insert(int item)
//         {
//             //if the array is full, resize it
//             ResizeIfRequired();

//             //add a new item at the end of teh array, count is initially 0
//             items[count++] = item;


//         }

//         public void ResizeIfRequired()
//         {
//             if (items.Length == count)
//             {
//                 //create a new array (twice the size)
//                 var newItems = new int[count * 2];

//                 //copy all existing items into new array
//                 for (int i = 0; i < count; i++)
//                 {
//                     newItems[i] = items[i];
//                 }

//                 //set items array to new array
//                 items = newItems;
//             }
//         }

//         public void RemoveAt(int index)
//         {
//             Console.WriteLine("Count:" + count);

//             //validate array index
//             if (index < 0 || index >= count)
//                 throw new IndexOutOfRangeException();

//             //2 3 5 4
//             //shift items to the left to fill the hole
//             for (int i = index; i < count; i++)
//             {
//                 items[i] = items[i + 1];

//             }

//             count--;

//         }

//         public int IndexOf(int item)
//         {
//             for (int i = 0; i < count; i++)
//                 if (items[i] == item)
//                     return i;


//             return -1;
//         }

//         public int Max()
//         {
//             //0(n)
//             int max = 0;

//             for (int i = 0; i < count; i++)
//             {
//                 if (items[i] > max)
//                 {
//                     max = items[i];
//                 }
//             }

//             return max;

//         }

//         public Array Intersect(Array other)
//         {
//             var intersection = new Array(count);

//             foreach (var item in items)
//             {
//                 if (other.IndexOf(item) >= 0)
//                 {
//                     intersection.Insert(item);
//                 }
//             }

//             return intersection;
//         }

//         public int[] Reverse()
//         {

//             var reversed = new int[count];

//             for (int i = 0; i < count; i++)
//             {
//                 int rIndex = count - 1;

//                 reversed[i] = items[rIndex - i];
//             }

//             return reversed;


//         }

//         public void InsertAt(int item, int index)
//         {
//             //validate array
//             if (index < 0 || index >= count)
//                 throw new IndexOutOfRangeException();

//             //increase size by 1
//             var newItems = new int[count + 1];

//             //count = 4 , index 2
//             //copy to new array
//             for (int i = 0; i < count; i++)
//             {
//                 newItems[i] = items[i];
//             }

//             //1 2 3 4 *
//             items = newItems;


//             for (int i = count - 1; i >= index; i--)
//             {
//                 items[i + 1] = items[i];
//             }

//             items[index] = item;

//             count++;
//         }

//         public static void MultiArray()
//         {
//             int[,] matrix = {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8}
//             };

//             for (int row = 0; row < matrix.GetLength(0); row++)
//             {

//                 for (int col = 0; col < matrix.GetLength(1); col++)
//                 {
//                     Console.Write("|" + matrix[row, col] + " |");
//                 }
//                 Console.WriteLine();
//             }

//         }

//         public static void MaximalPlatform()
//         {
//             int[,] matrix = {
//                 {0, 2, 4, 0, 9, 5},
//                 {7, 1, 3, 3, 2, 1},
//                 {1, 3, 9, 8, 5, 6},
//                 {4, 6, 7, 9, 1, 0}
//             };

//             int bestSum = int.MinValue;
//             int bestRow = 0;
//             int bestCol = 0;

//             for (int row = 0; row < matrix.GetLength(0) - 1; row++)
//             {
//                 for (int col = 0; col < matrix.GetLength(1) - 1; col++)
//                 {
//                     //0,0 0,1
//                     //1,0 1,1
//                     int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col]
//                                 + matrix[row + 1, col + 1];

//                     if (sum > bestSum)
//                     {
//                         bestSum = sum;
//                         bestRow = row;
//                         bestCol = col;
//                     }

//                 }
//             }


//             Console.WriteLine($"The maximal sum is {bestSum}");


//         }

//         public static void JaggedArray()
//         {
//             //Pascal Triangle
//             const int Height = 4;

//             var triangle = new int[Height + 1][];

//             var check = triangle.Length;

//             //fill each row with array
//             for (int i = 0; i < Height; i++)
//             {
//                 triangle[i] = new int[i + 1];
//             }

//             //calculate the pascals triangle
//             triangle[0][0] = 1;

//             for (int row = 0; row < Height - 1; row++)
//             {
//                 for (int col = 0; col <= row; col++)
//                 {
//                     triangle[row + 1][col] += triangle[row][col];
//                     triangle[row + 1][col + 1] += triangle[row][col];
//                 }
//             }



//         }

//         public static int HourGlass()
//         {
//             int[,] arr = {
//                             {1, 1, 1, 0, 0, 0},
//                             {0, 1, 0, 0, 0, 0},
//                             {1, 1, 1, 0, 0, 0},
//                             {0, 0, 2, 4, 4, 0},
//                             {0, 0, 0, 2, 0, 0},
//                             {0, 0, 1, 2, 4, 0}
//                         };

//             int total = int.MinValue;


//             for (int row = 0; row <= arr.GetLength(0) / 2; row++)
//             {
//                 for (int col = 0; col <= arr.GetLength(1) / 2; col++)
//                 {
//                     //top
//                     int sum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2];

//                     //middle
//                     sum += arr[row + 1, col + 1];

//                     //buttom
//                     sum += arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

//                     if (sum > total)
//                         total = sum;
//                 }
//             }


//             return total;

//         }

//         public static int[] RotateLeft(int[] arr, int d)
//         {

//             var arr2 = new int[arr.Length];

//             var rotateIndex = d;

//             int count = 0;

//             for (int i = 0; i < arr.Length - d; i++)
//             {
//                 arr2[i] = arr[rotateIndex];

//                 count++;

//                 rotateIndex++;
//             }

//             rotateIndex = 0;


//             for (int i = count; i < arr.Length; i++)
//             {
//                 arr2[i] = arr[rotateIndex];
//                 rotateIndex++;
//             }

//             return arr2;

//         }

//         public static int MinimumSwaps(int[] arr)
//         {
//             //4 3 1 2

//             int count = 0;

//             //


//             for (int i = 0; i < arr.Length; i++)
//             {
//                 while (arr[i] != i + 1)
//                 {
//                     //swap
//                     var value = arr[i];

//                     var temp = arr[value - 1]; //2 

//                     arr[value - 1] = value;
//                     arr[i] = temp;

//                     count++;

//                 }
//             }

//             return count;
//         }

//         public static void NewYearChaos(int[] arr)
//         {
//             //2 1 5 3 4

//             //max moves <= 2

//             //string print = null;

//             int count = 0;


//             for (int i = 0; i < arr.Length; i++)
//             {
//                 int pos = i + 1;

//                 while (arr[i] != pos)
//                 {


//                     var value = arr[i];

//                     var temp = arr[value - 1];

//                     //condition
//                     if ((value - pos) > 2)
//                     {
//                         Console.WriteLine("Too chaotic");
//                         return;
//                     }
//                     else
//                     {
//                         arr[i] = temp;
//                         arr[value - 1] = value;

//                         count++;
//                     }

//                 }
//             }


//             Console.WriteLine(count);


//         }

//         public static int[] MoveZeros(int[] arr)
//         {
//             var track = 0;

//             for (int i = 0; i < arr.Length; i++)
//             {
//                 if (arr[i] != 0)
//                 {
//                     arr[track] = arr[i];
//                     track++;
//                 }


//             }

//             for (int i = track; i < arr.Length; i++)
//             {
//                 arr[i] = 0;
//             }


//             return arr;
//         }




//     }
// }