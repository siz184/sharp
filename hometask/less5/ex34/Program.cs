int[] FillArray(int count){
    int[] arr = new int[count];
    for(int i=0; i<count; i++){
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

int CountEven(int[] arr){
    int even = 0;
    for(int i=0; i<arr.Length; i++){
        if(arr[i]%2==0){
            even++;
        }
    }
    return even;
}

void PrintArray(int[] arr){
    for(int i=0; i<arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


int[] newArr = FillArray(8);
int even = CountEven(newArr);
PrintArray(newArr);
Console.WriteLine($"Кол-во чётных элементов в массиве: {even}");