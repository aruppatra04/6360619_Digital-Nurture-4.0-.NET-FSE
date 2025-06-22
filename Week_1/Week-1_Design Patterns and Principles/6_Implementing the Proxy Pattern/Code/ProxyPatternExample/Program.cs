using System;

class Program
{
    static void Main()
    {
        Image img1 = new ProxyImage("photo1.jpg");
        Image img2 = new ProxyImage("photo2.jpg");
        Image img3 = new ProxyImage("photo1.jpg"); 

        img1.Display(); 
        img2.Display(); 
        img3.Display(); 
    }
}
