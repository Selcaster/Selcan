#region Vilayat muellimin tapsirigi
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
#endregion
#region Overload1
//Overload Tasks :
//1.Area deyə Method(lar) yaradılır.
//1.Çevrənin sahəsi - S = p * r² (p = 3)
//2.Düzbucaqlının sahəsi - S = a * b
//3.Düzbucaqlı paralelpipedin tam səthinin sahəsi -
//S=2(a*b+a*c+b*c)
//4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p = (a + b + c) / 2
//public class program
//{
//    static void Main()
//    {
//        double radius = 2;
//        double duzbucaqa = 5, duzbucaqb = 4;
//        double ppipeda = 5, ppipedb = 3, ppipedc = 2;
//        double uca = 4, ucb = 5, ucc = 4;
//        Area(radius);
//        Area(duzbucaqa, duzbucaqb);
//        Area(ppipeda, ppipedb, ppipedc);
//        Area(uca, ucb, ucc, radius);
//    }
//    static void Area(double r)
//    {
//        Console.WriteLine(r * r * 3);
//    }
//    static void Area(double a, double b)
//    {
//        Console.WriteLine(a * b);
//    }
//    static void Area(double a, double b, double c)
//    {
//        Console.WriteLine(2 * (a * b + a * c + b * c));
//    }
//    static void Area(double a, double b, double c, double r)
//    {
//        double p = (a + b + c) / 2;
//        Console.WriteLine(p * r);
//    }
//}
#endregion
#region a
//a.Method yaradirsiz 2 eded ve 1 operator('+','-','*','/') qebul edir.
//Qebul etdiyi operatora uygun a v' b ədədləri üzərində hesablama aparib alinan deyeri qaytarır.
//public class program 
//{
//    static void Main() 
//    {
//        int a = Convert.ToInt32(Console.ReadLine());
//        char c = Convert.ToChar(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        Calculator(a, b, c);
//    }
//    static void Calculator(int a, int b, char c) 
//    {
//        if (c == '+') Console.WriteLine(a + b);
//        else if (c == '-')Console.WriteLine(a - b);
//        else if (c == '*') Console.WriteLine(a * b);
//        else if (c == '/') Console.WriteLine(a / b);
//        else Console.WriteLine("Burada hec bir emeliyyat aparmaq mumkun deyil.");
//    }
//}
#endregion
#region b
//b.Method yaradırsız əgər methoda bir eded gonderilirse hemin ededin kvadratını, 
//iki eded gonderilirse 1ci ədədi ikinci ədəd qədər qüvvətinə yüksəldirsiz.(Misal: MyMethod(2, 3)-- > 8)
//public class Program 
//{
//    static void Main() 
//    {
//        int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
//        MyMethod(a);
//        MyMethod(a, b);
//    }
//    static void MyMethod(int a) 
//    { 
//        Console.WriteLine(a * a); 
//    }
//    static void MyMethod(int a, int b) 
//    {
//        int c = 1;
//        for (int i = 0; i < b; i++) c *= a;
//        Console.WriteLine(c);
//    }
//}
#endregion
#region c
//c.Methodlar yaradirsiz. Methoda ad gonderende adi ekrana cixardir(Sabir), 
//ad ve soyad gonderende soyadi adi ekrana cixardir(Guliyev Sabir), 
//ad, soyad ve ata adı göndərildikdə adin baş hərfi nöqtə soyad ata adi ekrana cixardirsiz(S.Guliyev Mehti). 
//Methodlarin adi eyni olmalıdır.
//public class program 
//{
//    static void Main() 
//    {
//        string ad = Console.ReadLine(), soyad = Console.ReadLine(), ataadi = Console.ReadLine();
//        ADPRINTER(ad);
//        ADPRINTER(ad, soyad);
//        ADPRINTER(ad, soyad, ataadi);
//    }
//    static void ADPRINTER(string a) 
//    {
//        Console.WriteLine(a);
//    }
//    static void ADPRINTER(string a, string b) 
//    {
//        Console.WriteLine(b+' '+a);
//    }
//    static void ADPRINTER(string a, string b, string c) 
//    {
//        Console.Write(a[0] + ". ");
//        Console.Write(b+" "+c);
//    }
//}
#endregion
