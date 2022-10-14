Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void ShowNumbers(int num){
    if(num==1){
        Console.Write($"{num}");
    }else{
        Console.Write($"{num}, ");
        num = num - 1;
        ShowNumbers(num);
    }
}
ShowNumbers(num);