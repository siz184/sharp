Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int sum, int M, int N){
    if(M < N){
        return SumNumbers(sum + M,M + 1,N);
    }else{
        return sum + M;
    }
}
int sum = SumNumbers(0,M,N);
Console.WriteLine($"Сумма чисел от {M} до {N}: {sum}");