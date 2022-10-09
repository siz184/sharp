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

dynamic showElement(int[,] arr, int rowPosition, int colPosition){
    int x = arr.GetLength(0);
    int y = arr.GetLength(1);
    if(x > rowPosition && y > colPosition){
        return arr[rowPosition,colPosition];
    }else{
        return $"Элемента с позицией ({rowPosition},{colPosition}) в массиве нет";
    }
}

Console.Write("Введите номер строки: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int colPosition = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillArray(3,4); 
PrintArray(arr);

Console.WriteLine(showElement(arr,rowPosition,colPosition)); 





