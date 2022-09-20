void SecondNum(){
    Console.Write("Введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int prov100 = num/100;
    if(prov100<1 || prov100>10){
        Console.WriteLine("Введено не трёхзначное число!");
        SecondNum();
    }else{
        int res = num%100/10;
        Console.Write("Вторая цифра введенного числа: "+res);
    }
}

SecondNum();