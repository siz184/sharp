Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
for(int i=1;i<=num;i++){
    result = result + i;
}
Console.WriteLine(result);