void calcLength(){

    Console.Write("Введите координаты первой точки через запятую: ");
    string? pointA = Console.ReadLine();
    Console.Write("Введите координаты второй точки через запятую: ");
    string? pointB = Console.ReadLine();

    //if(string.IsNullOrEmpty(pointA) || string.IsNullOrEmpty(pointB)){
    if(pointA == null || pointB == null){

        Console.WriteLine("Введены пустые значения!");
        calcLength();
        
    }else{

        //string[] coordsA = pointA.Split(","," ");
        int[] coordsA = pointA.Split(',').Where(x => !string.IsNullOrWhiteSpace( x )).Select(x => int.Parse(x)).ToArray();
        //string[] coordsB = pointB.Split(","," ");
        int[] coordsB = pointB.Split(',').Where(x => !string.IsNullOrWhiteSpace( x )).Select(x => int.Parse(x)).ToArray();

        double distance = Math.Round(
            Math.Sqrt( 
                Math.Pow(coordsB[0] - coordsA[0],2) + 
                Math.Pow(coordsB[1] - coordsA[1],2) + 
                Math.Pow(coordsB[2] - coordsA[2],2)
            ),2
            );
        Console.WriteLine($"Расстояние между точками {distance}");
    }

}

calcLength();
