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

int SumRow(int[,] arr, int row){
    int sum = 0;
    for(int i=0; i<arr.GetLength(1); i++){
        sum += arr[row,i];
    }
    return sum;
}

int MinArrKey(int[] arr){
    int min = 0;
    for(int i=1; i<arr.Length; i++){
        if(arr[i]<arr[min]){
            min = i;
        }
    }
    return min;
}

int[,] arr = FillArray(4,4);
int[] sumRows = new int[arr.GetLength(0)];

PrintArray(arr);
Console.WriteLine();

for(int i=0; i<arr.GetLength(0); i++){
    sumRows[i] = SumRow(arr,i);
}

int minRow = MinArrKey(sumRows) + 1; // +1 для номера строки

Console.WriteLine($"Наименшая сумма элементов в строке № {minRow}");