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

int[,] SortArr(int[,] arr, int row){
            int tmp, max;
            for (int j = 0; j < arr.GetLength(1) - 1; j++){
                max = j;
                for (int k = j + 1; k < arr.GetLength(1); k++){
                    if (arr[row,k] > arr[row,max]){
                        max = k;
                    }
                }
                tmp = arr[row,max];
                arr[row,max] = arr[row,j];
                arr[row,j] = tmp;
            }
            return arr;
        }

int[,] arr = FillArray(3,4);

PrintArray(arr);
Console.WriteLine();

for(int i=0; i<arr.GetLength(0); i++){
    arr = SortArr(arr,i);
}

PrintArray(arr);