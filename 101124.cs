//public class Program
//{
//    static void Main()
//    {
//        string s = "SALAm, can, necesen? Ele! Bildim* Cucesen#";
//        Console.WriteLine(strclear(s));
//    }
//    static string strclear(string s)
//    {
//        string s1 = "";
//        char c = '\0';
//        for (int i = 0; i < s.Length; i++)
//        {
//            c = s[i];
//            if ((c <= 90 && c >= 65)|| (c <= 122 && c >= 97)||c==32)
//            s1 += c;
//        }
//        return s1;
//    }
//    //static 
//}
#region Overload1
//Overload Tasks :
//1.Area deyə Method(lar) yaradılır.
//1.Çevrənin sahəsi - S = p * r² (p = 3)
//2.Düzbucaqlının sahəsi - S = a * b
//3.Düzbucaqlı paralelpipedin tam səthinin sahəsi -
//S=2(a*b+a*c+b*c)
//4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p = (a + b + c) / 2
public class program 
{
    static void Main() 
    {
        double radius=2;
        double duzbucaqa=5, duzbucaqb=4;
        double ppipeda=5, ppipedb=3, ppipedc=2;
        double uca=4, ucb=5, ucc=4;
        Area(radius);
        Area(duzbucaqa,duzbucaqb);
        Area(ppipeda, ppipedb,ppipedc);
        Area(uca, ucb, ucc, radius);
    }
    static void Area(double r) 
    {
        Console.WriteLine(r * r * 3);
    }
    static void Area(double a, double b)
    {
        Console.WriteLine(a * b);
    }
    static void Area(double a, double b, double c)
    {
        Console.WriteLine(2*(a * b + a * c + b * c));
    }
    static void Area(double a, double b, double c, double r)
    {
        int p = (a + b + c) / 2;
        Console.WriteLine(p*r);
    }
}
#endregion
