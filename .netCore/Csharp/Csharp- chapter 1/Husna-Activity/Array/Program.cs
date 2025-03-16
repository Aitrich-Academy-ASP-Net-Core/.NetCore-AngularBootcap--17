namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] myarray = new int[3] { 23, 12, 45 };
             foreach(var num in myarray)
             {
                 Console.WriteLine(num);
             }
            int[ , ] twodarray = new int[4, 3] { { 3, 4, 5 }, { 3, 2, 6 }, { 2, 8, 9 }, { 5, 1, 5 } };
            foreach(var elements in twodarray)
            {
                Console.Write(elements);
            }
            string[] names = new string[5] { "ahmed", "muhammed", "hasna", "ayzin", "azza" };
            Console.WriteLine("list of names");
            foreach(var person in names)
            {
                Console.WriteLine(person);
            }
            List<string> students = new List<string> { "ahmed", "muhammed", "hasna", "ayzin", "azza" };
            Console.WriteLine("Student list");
            foreach (string person in students)
            {
                Console.WriteLine(person);
            }
            Sum and average of an integer array
            int[] numbers = new int[6] { 34, 24, 56, 45, 34, 56 };
            int sum = 0;
            int count = 0;
            foreach(int num in numbers)
            {
                sum = sum + num;
                count++;
            }
            double average = sum / count;
            Console.WriteLine("Sum:" + "" + sum);
            Console.WriteLine("Average:" + "" + average);

            Using Dictionary
            Dictionary<string, double> employees = new Dictionary<string, double>
            {
                {"Neha",55000 },
                {"jiha",25000 },
                {"sneha",50000 },
                {"faana",35000 },
                {"reeha",15000 }

            };
            Console.WriteLine("Employee details");
            foreach(KeyValuePair<string,double> employee in employees)
            {
                Console.WriteLine("Name:" + " " + employee.Key +" "+ "Salary:" + " " + employee.Value);
            }




            ARRAYS
            Iterate and print using forloop and foreach
            int[] numbers = new int[10] { 45, 56, 34, 23, 12, 34, 57, 88, 78, 66 };
            Console.WriteLine("using for loop");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\nusing foreach");
            foreach(int nums in numbers)
            {
                Console.WriteLine(nums);
            }
            To find the maximum and minimum number from an integer array


            int[] myarray = new int[7] { 45, 56, 34, 23, 12, 34, 57 };
            int max = myarray[0];
            int min = myarray[0];
            foreach(int num in myarray)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine("Greatest number in the array" + max);
            Console.WriteLine("Smallest number in the array" + min);
            string[] array = new string[] { "alice","mehna","nehda"};
            string reverse = "";
            for(int i = array.Length - 1; i >= 0; i--)
            {
                reverse = reverse + array[i]+" ";
            }
            Console.WriteLine(reverse);



            Check for an element


            Console.WriteLine("Enter a number");
            int userinput = Convert.ToInt32(Console.ReadLine());
            int[] myarray = new int[7] { 45, 56, 34, 23, 12, 34, 57 };
            bool found = false;
            foreach (int num in myarray)
                {
                    if (userinput == num)
                    {
                        found = true;
                        break;
                    }
                }

            if (found)
            {
                Console.WriteLine("Exists in the array");
            }
            else
            {
                Console.WriteLine("Not exist in the array");
            }



           // TWO DIMENSIONAL ARRAY
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6}
        };

            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
      
                Console.Write("Enter number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());

                int[,] matrix = new int[rows, cols];

                Console.WriteLine("Enter matrix elements:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Matrix:");




                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();

                }
            Sum of all elements in a matrix

        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int sum = 0;

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                sum += matrix[i, j]; // Add each element to sum
            }
        }

        Console.WriteLine("\nMatrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nSum of all elements: {sum}");



           // transpose
    
                Console.Write("Enter number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());

                int[,] matrix = new int[rows, cols];
                int[,] transpose = new int[cols, rows]; // Transposed matrix dimensions

                Console.WriteLine("Enter matrix elements:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Computing the transpose
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        transpose[j, i] = matrix[i, j]; // Swapping rows and columns
                    }
                }

                Console.WriteLine("\nOriginal Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nTransposed Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[j,i] + "\t");
                }
                Console.WriteLine();
            }
              To find the maximum and minimum number in  matrix
     
                Console.Write("Enter number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());

                int[,] matrix = new int[rows, cols];

                Console.WriteLine("Enter matrix elements:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("Element [" + i + "," + j + "]: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Initialize max and min with the first element of the matrix
                int max = matrix[0, 0];
                int min = matrix[0, 0];

                // Finding max and min values
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] > max)
                            max = matrix[i, j];

                        if (matrix[i, j] < min)
                            min = matrix[i, j];
                    }
                }

                Console.WriteLine("\nMatrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nMaximum Value: {max}");
                Console.WriteLine($"Minimum Value: {min}");



            Add 2 matrices

            Console.Write("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] resultMatrix = new int[rows, cols];

            Console.WriteLine("Enter elements of first matrix");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write("Element [" + i + "," + j + "]: ");
                    matrix1[i, j] =Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of second matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Element [" + i + "," + j + "]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }


            Console.WriteLine("Result");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");

                }
                Console.WriteLine();
            }


           
            Jagged Array

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 2, 3 };
            jaggedArray[1] = new int[] { 3, 1, 6 };
            jaggedArray[2] = new int[] { 2, 8, 9, 7 };
            // Printing the jagged array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
               for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }


            Sum of elements of row in a Jagged Array

            int[][] jaggedArray = { new int[] { 3, 2, 5, 6 },
                                    new int[] { 7, 3, 5 },
                                    new int[] { 1, 2 }
                                   };
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                int sum = 0;
                foreach(int num in jaggedArray[i])
                {
                    
                    sum = sum + num;

                }
                Console.WriteLine("Sum:" + " " + sum);
            }


            Find the largest element in a jagged array


            int[][] jaggedArray = { new int[]{3,5,7,1},
                                    new int[]{1,2,3},
                                    new int[]{2,7,6,4}
            };
            int maxNum = jaggedArray[0][0];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
              foreach(int num in jaggedArray[i])
                {
                    if (num > maxNum)
                    {
                        maxNum = num;
                    }
                } 

            }
            Console.WriteLine("Greatest number is" + " " + maxNum);


            Search for an element in a jagged array

            int[][] jaggedArray = { new int[]{3,5,7,1},
                                    new int[]{1,2,3},
                                    new int[]{2,7,6,4}
            };
            Console.WriteLine("Enter a number to search");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length;j++)
                {
                    if (userInput == jaggedArray[i][j])
                    {
                        found = true;
                        Console.Write("The element is found at index"+" "+"[" +
                            "" +i+" "+j+"]");
                    }
                }

            }
            if (!found)
            {
                Console.WriteLine("not found");
            }

            Hollow square pattern
            int size = 5;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                   
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }


            Triangular number sequence
            int rows = 5; 
            int num = 1;  

            for (int i = 1; i <= rows; i++) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++; 
                }
                Console.WriteLine(); 
            }



            Pascals triangle

            int rows = 5; 

            for (int i = 0; i < rows; i++)
            {
                int number = 1; 

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " "); 

                    
                    number = number * (i - j) / (j + 1);
                }

                Console.WriteLine();
            }*/



            //Hollow triangle pattern


            int rows = 5; 

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    
                    if (j == 1 || i == rows||i==j)
                        Console.Write("* ");
                    else
                        Console.Write("  "); 
                }
                Console.WriteLine(); 
            }




























        }
    }
}
