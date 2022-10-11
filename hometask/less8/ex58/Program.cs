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

int[,] matrix1 = FillArray(2,2);
int[,] matrix2 = FillArray(2,2);

int[,] matrixProduct = new int[2,2];

for(int i=0; i<matrix1.GetLength(0); i++){
    for(int j=0; j<matrix2.GetLength(0); j++){
        for (int k = 0; k < matrix2.GetLength(1); k++){
            matrixProduct[i,j] += matrix1[i,k]*matrix2[k,j];
        }
    }
}

Console.WriteLine("Матрица 1");
PrintArray(matrix1);
Console.WriteLine("Матрица 2");
PrintArray(matrix2);
Console.WriteLine("Произведение матриц");
PrintArray(matrixProduct);