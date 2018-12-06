using System;

namespace RectangleAmmplication{

//Declaration d'une classe 
class Rectangle{
    
    //Variable declaration
    double length;
    double width;

public void AcceptDetails(){
    length = 10;
    width = 20;
}
public double getArea(){
    return length*width;
}

public void display(){
    Console.WriteLine("Lenght : {0}",length);
    Console.WriteLine("Width {0}",width);
}

}

class ExecuteRectangle{
public static void Main(String[] args){
    Rectangle rec1 = new Rectangle();
    rec1.AcceptDetails();
    rec1.display();
    Console.ReadLine();
}
}

}