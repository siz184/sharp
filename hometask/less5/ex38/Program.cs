double[] FillArray(int count){
    Random random = new Random();
    double[] arr = new double[count];
    for(int i=0; i<count; i++){
        arr[i] = Math.Round(random.NextDouble() * 100,2);
    }
    return arr;
}

double MaxMinDiff(double[] arr){
    int max = 0;
    int min = 0;
    for(int i=1; i<arr.Length; i++){
        if(arr[i]>arr[max]){
            max = i;
        }
        if(arr[i]<arr[min]){
            min = i;
        }
    }
    double diff = arr[max] - arr[min];
    return diff;
}

void PrintArray(double[] arr){
    for(int i=0; i<arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


double[] newArr = FillArray(8);
double newDiff = MaxMinDiff(newArr);
PrintArray(newArr);
Console.WriteLine($"Разница максимального и минимального элементов массива: {newDiff}");