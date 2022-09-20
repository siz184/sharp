void weekDay(){
    Console.Write("Введите цифру от 1 до 7: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num < 1 || num > 7){
        Console.WriteLine("Цифра не в интервале от 1 до 7!");
        weekDay();
    }else{  
        string res = "будни";
        if(num==6 || num==7){
            res = "выходной"; 
        }
        Console.WriteLine("День недели под номером "+num+" - "+res);
    }
}

weekDay();
