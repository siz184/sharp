Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num<100){
    Console.WriteLine("Третьей цифры нет!");
}else{  
    while(num > 1000){
        num = num/10;
    }
    int res = num%100%10; 
    Console.WriteLine("Третья цифра: "+res);
}


