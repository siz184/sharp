double[,] FillArray(int m, int n){
    double[,] arr = new double[m,n];
    Random random = new Random();
    for(int i=0; i<m; i++){
        for(int j=0; j<n; j++){
            arr[i,j] = Math.Round(random.NextDouble() * 10,1);
        }
    }
    return arr;
}

void PrintArray(double[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++){
           Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[,] arr = FillArray(3,4);
PrintArray(arr);