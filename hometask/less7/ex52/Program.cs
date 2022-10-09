int[,] FillArray(int x, int y){
    int[,] arr = new int[x,y];
    Random random = new Random();
    for(int i=0; i<x; i++){
        for(int j=0; j<y; j++){
            arr[i,j] = random.Next(0,10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++){
           Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] getAverage(int[,] arr){
    int col = arr.GetLength(1);
    int row = arr.GetLength(0);

    double[] average = new double[col];
    for(int i=0; i<col; i++){
        int summ = 0;
        for(int j=0; j<row; j++){
           summ += arr[j,i];
        }
        average[i] = Math.Round(Convert.ToDouble(summ) / Convert.ToDouble(row),1);  
    }
    return average;
}

int[,] arr = FillArray(3,4);
double[] average = getAverage(arr);
PrintArray(arr);

Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ",average)}.");