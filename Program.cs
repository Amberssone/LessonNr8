// 8 Урок
/* 1 Задание 

{
  
        int[] arr = new int[] {1, 9, 6, 7, 5, 9};
  
        Array.Sort(arr);
        Array.Reverse(arr);
        foreach(int value in arr)

        {
            Console.Write(value + " ");
        }
    }
    */

    /* 2 Задание 

{
    static int ROW = 4;
    static int COL = 5;
    static int start;
    static int finish;
    static int kadane(int[] arr, int n)
    {
        int sum = 0, minSum = Int32.MaxValue, i;
        finish = -1;
        int local_start = 0;
   
        for (i = 0; i < n; ++i)
        {
            sum += arr[i];
            if (sum > 0)
            {
                sum = 0;
                local_start = i + 1;
            }
          else if (sum < minSum)
          {
                minSum = sum;
                start = local_start;
                finish = i;
            }
        }
          
        if (finish != -1)
            return minSum;
        
        minSum = arr[0];
        start = finish = 0;
        
        for (i = 1; i < n; i++)
        {
            if (arr[i] < minSum)
            {
                minSum = arr[i];
                start = finish = i;
            }
        }
        return minSum;
    }
}

*/

/* 3 Задание 

{
        int i,j,k,r1,c1,r2,c2,sum=0;
  
      	int[,] arr1 = new int[50,50];
		int[,] brr1 = new int[50,50];
		int[,] crr1 = new int[50,50];
  
       Console.Write("\n\nMultiplication of two Matrices\n");
       Console.Write("----------------------------------\n");  

  Console.Write("\nInput the number of rows and columns of the first matrix :\n");	   
  Console.Write("Rows : ");
  r1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Columns : ");  
  c1 = Convert.ToInt32(Console.ReadLine());

  Console.Write("\nInput the number of rows of the second matrix :\n");  
  Console.Write("Rows : ");
  r2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Columns : ");   
  c2 = Convert.ToInt32(Console.ReadLine());  
  
  if(c1!=r2){
      Console.Write("Mutiplication of Matrix is not possible.");
      Console.Write("\nColumn of first matrix and row of second matrix must be same.");
  }
  else
      {
       Console.Write("Input elements in the first matrix :\n");
       for(i=0;i<r1;i++)
        {
            for(j=0;j<c1;j++)
            {
	           Console.Write("element - [{0}],[{1}] : ",i,j);
			   arr1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }   
       Console.Write("Input elements in the second matrix :\n");
       for(i=0;i<r2;i++)
        {
            for(j=0;j<c2;j++)
            {
	           Console.Write("element - [{0}],[{1}] : ",i,j);
			   brr1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }    
 	 Console.Write("\nThe First matrix is :\n");
  		for(i=0;i<r1;i++)
    		{
      		Console.Write("\n");
      		for(j=0;j<c1;j++)
          	Console.Write("{0}\t",arr1[i,j]);
    		}
  
  	Console.Write("\nThe Second matrix is :\n");
  		for(i=0;i<r2;i++)
    		{
      		Console.Write("\n");
      		for(j=0;j<c2;j++)
      		Console.Write("{0}\t",brr1[i,j]);
    		}

      for(i=0;i<r1;i++)
          for(j=0;j<c2;j++)
           crr1[i,j]=0;
             for(i=0;i<r1;i++)
                 { 
                   for(j=0;j<c2;j++)
                     {  
                       sum=0;
                         for(k=0;k<c1;k++)
                           sum=sum+arr1[i,k]*brr1[k,j];
                           crr1[i,j]=sum;
                     }
                 }
  Console.Write("\nThe multiplication of two matrix is : \n");
  for(i=0;i<r1;i++)
     {
        Console.Write("\n");
        for(j=0;j<c2;j++)
         {
           Console.Write("{0}\t",crr1[i,j]);
         }
     }
  }
Console.Write("\n\n");
  }
*/

// 4 задание 

/* 5 задание 
{

    {
        static void Main(string[] args)
        {
            int m = 0, n = 0, start = 0, step = 0;
            bool errorOcured = false;
            Console.WriteLine("====Spiral Matrix====\n");
            try
            {
                Console.WriteLine("Enter size of the matrix:");
                Console.Write("Row (m)? ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Column (n)? ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the starting number: ");
                start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter step: ");
                step = Convert.ToInt32(Console.ReadLine());
                if (m < 0 || n < 0 || start < 0 || step < 0) throw new FormatException();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong input. [Details: {0}]", e.Message);
                Console.WriteLine("Program will now exit...");
                errorOcured = true;
            }

            if (!errorOcured)
            {
                int[,] mat = new int[m, n];
                mat = initMatrix(m, n, start, step);

                Console.WriteLine("\nIntial matrix generated is:");
                displayMatrix(mat, m, n);

                Console.WriteLine("\nSpiral Matrix generated is:");
                mat = calculateSpider(mat, m, n);
                displayMatrix(mat, m, n);
            }
            Console.Write("\nPress enter to exit...");
            Console.Read();
        }
        private static int[,] initMatrix(int m, int n, int start, int step)
        {
            int[,] ret = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ret[i, j] = start;
                    start += step;
                }
            }
            return ret;
        }
        private static void displayMatrix(int[,] mat, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t{0}", mat[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static int[,] calculateSpider(int[,] mat, int m, int n)
        {
            int[,] intMat;
            if (m <= 2 || n <= 2)
            {

                if (m == 2 && n == 2)
                {
                    int[,] t = new int[m, n];
                    t[0, 0] = mat[0, 0];
                    t[0, 1] = mat[0, 1];
                    t[1, 0] = mat[1, 1];
                    t[1, 1] = mat[1, 0];
                    return t;
                }
                else if (m == 2)
                {
                    int[,] t = new int[m, n];
                    for (int i = 0; i < n; i++)
                    {
                        t[0, i] = mat[0, i];
                        t[1, n - 1 - i] = mat[1, i];
                    }
                    return t;
                }
                else if (n == 2)
                {
                    int[,] t = new int[m, n];
                    int[] stMat = new int[m * n];
                    int c = 0;
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            stMat[c] = mat[i, j];
                            c++;
                        }
                    }
                    c = 0;
                    for (int i = 0; i < n; i++)
                    {
                        t[0, i] = stMat[c];
                        c++;
                    }
                    for (int i = 1; i < m; i++)
                    {
                        t[i, 1] = stMat[c];
                        c++;
                    }
                    if(m>1) t[m - 1, 0] = stMat[c];
                    c++;
                    for (int i = m - 2; i >= 1; i--)
                    {
                        t[i, 0] = stMat[c];
                        c++;
                    }
                    return t;
                }
                else return mat;
            }
            intMat = new int[m - 2, n - 2];
            int[,] internalMatrix = new int[m - 2, n - 2];
            for (int i = 0; i < ((m - 2) * (n - 2)); i++)
            {
                internalMatrix[(m - 2) - 1 - i / (n - 2), (n - 2) - 1 - i % (n - 2)] = mat[m - 1 - (i / n), n - 1 - (i % n)];
            }
            intMat = calculateSpider(internalMatrix, m - 2, n - 2);

            int[,] retMat = new int[m, n];
            int[] tempMat = new int[(m * n) - ((m - 2) * (n - 2))];
            for (int i = 0; i < (m * n) - ((m - 2) * (n - 2)); i++)
            {
                tempMat[i] = mat[i / n, i % n];
            }
            int count = 0;
        
            for (int i = 0; i < n; i++)
            {
                retMat[0, i] = tempMat[count];
                count++;
            }
        
            for (int i = 1; i < m; i++)
            {
                retMat[i, n - 1] = tempMat[count];
                count++;
            }
            
            for (int i = n - 2; i >= 0; i--)
            {
                retMat[m - 1, i] = tempMat[count];
                count++;
            }
            
            for (int i = m - 2; i >= 1; i--)
            {
                retMat[i, 0] = tempMat[count];
                count++;
            }
    
            for (int i = 1; i < m - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    retMat[i, j] = intMat[i - 1, j - 1];
                }
            }
            return retMat;
        }
    }
}
/*
