Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num2 > num1){
    max = num2;
}
Console.WriteLine("Большее число: "+max);