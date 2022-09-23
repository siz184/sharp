void checkPalindrom(){

    Console.Write("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num >= 10000 && num < 100000){

        string numStr = Convert.ToString(num);
        char[] numArr = numStr.ToCharArray();
        if(numArr[0]==numArr[4] && numArr[1]==numArr[3]){
            Console.WriteLine("Введеное число - палиндром!");
        }else{
            Console.WriteLine("Введеное число - не палиндром!");
        }

    }else{

        Console.WriteLine("Введено не пятизначное число!");
        checkPalindrom();

    }
}

checkPalindrom();
