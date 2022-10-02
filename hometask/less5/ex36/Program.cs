int[] FillArray(int count){
    int[] arr = new int[count];
    for(int i=0; i<count; i++){
        arr[i] = new Random().Next(-99,100);
    }
    return arr;
}

int SumOdd(int[] arr){
    int sum = 0;
    for(int i=1; i<arr.Length; i=i+2){
        sum = sum + arr[i];
    }
    return sum;
}

void PrintArray(int[] arr){
    for(int i=0; i<arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


int[] newArr = FillArray(8);
int sum = SumOdd(newArr);
PrintArray(newArr);
Console.WriteLine($"Сумма элементов в массиве, стоящих на нечётных позициях: {sum}");