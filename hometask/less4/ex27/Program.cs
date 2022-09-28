Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int pro = num;
int sum = 0;
while(pro >= 1){
    sum = sum + pro%10;
    pro = pro/10;
}
Console.WriteLine($"Сумма цифр числа {num}: {sum}");