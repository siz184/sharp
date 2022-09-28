int[] arr = new int[8];
for(int i=0; i<arr.Length; i++){
    arr[i] = new Random().Next(0,100);
    Console.Write($"{arr[i]} ");
}
