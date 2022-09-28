Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int deg = Convert.ToInt32(Console.ReadLine());
int result = num;
for(int i=2; i<=deg; i++){
    result = result*num;
}
Console.WriteLine($"Число {num} в степени {deg} равно {result}");