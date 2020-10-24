using System;

//BÀI 1:


class Diem
{
    private double x, y;
    public Diem()
    {
        x = y = 0;
    }
    public Diem(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public void Nhap()
    {
        Console.Write("Nhap x:");
        x = double.Parse(Console.ReadLine());
        Console.Write("Nhap y:");
        y = double.Parse(Console.ReadLine());
    }
    public void Hien()
    {
        Console.WriteLine("Toa do (x,y)=({0},{1})");
    }
    public double TinhDT(Diem B)
    {
        return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
    }
}

//BÀI 2:
class Employee
{
    private int id;
    private string name;
    private int yearOfBirth;
    private double salaryLever;
    private double basicSalary;
    public int getld()
    {
        return id;
    }
    public string getname()
    {
        return name;
    }
    public int getyearOBirth()
    {
        return yearOfBirth;
    }
    public double getIncome()
    {
        return salaryLever * basicSalary;
    }
    public void display()
    {
        Console.WriteLine("Thong tin ve nguoi lao dong:");
        Console.Write("Dinh danh", id, "Ten", name, "Nam sinh", yearOfBirth, "Luong co ban", basicSalary, "Thu nhap", getIncome());
    }
}

//bai 4

class SoPhuc
{
    private double thuc, ao;
    public SoPhuc()
    {
        thuc = 0;
        ao = 0;
    }
    public SoPhuc(double thuc, double ao)
    {
        this.thuc = thuc;
        this.ao = ao;
    }
    public SoPhuc(SoPhuc t2)
    {
        this.thuc = t2.thuc;
        this.ao = t2.ao;
    }
    public void Nhap()
    {
        Console.Write("Nhap phan thuc:"); thuc = double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao:"); ao = double.Parse(Console.ReadLine());
    }
    public void Hien()
    {
        string kq = thuc + (ao > 0 ? "+" : "") + ao + "*i";
        Console.WriteLine(kq);
    }
    public static SoPhuc operator +(SoPhuc t1, SoPhuc t2)
    {
        SoPhuc tmp = new SoPhuc();
        tmp.thuc = t1.thuc + t2.thuc;
        tmp.ao = t1.ao + t2.ao;
        return tmp;
    }
    public SoPhuc Tong(SoPhuc t2)
    {
        SoPhuc tmp = new SoPhuc();
        tmp.thuc = this.thuc + t2.thuc;
        tmp.ao = this.ao + t2.ao;
        return tmp;
    }
}
class App
{
    static void Main()
    {
        SoPhuc t1 = new SoPhuc(5, 8);
        SoPhuc t2 = new SoPhuc(t1);
        Console.WriteLine("So phuc thu nhat"); t1.Hien();
        Console.WriteLine("So phuc thu hai"); t2.Hien();
        SoPhuc t3 = t1 + t2;//t1.Tong(t2);
        Console.WriteLine("So phuc tong"); t3.Hien();
        Console.ReadLine();
    }
}
// bai 3
class Stack
{
    private int top;
    private int[] s;
    public Stack()
    {
        top = -1;
        s = new int[20];

    }
    public Stack(int n)
    {
        top = -1;
        s = new int[n];
    }
    public bool Full()
    {
        return top == s.Length - 1;
    }
    public bool Empty()
    {
        return top == -1;
    }
    public void Push(int x)
    {
        if (Full()) Console.WriteLine("Stack day");
        else s[++top] = x;
    }
    public int Pop()
    {
        if (Empty()) throw new Exception("Stack rong");
        else
        {
            int x = s[top--];
            return x;
        }
    }
}
class App
{
    static void Main()
    {
        int n;
        Stack t = new Stack();
        Console.WriteLine("Nhap vao so nguyen n:");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            t.Push(n % 2);
            n = n / 2;
        }
        Console.Write("So nhi phan tuong ung:");
        while (!t.Empty())
            Console.Write(t.Pop());
        Console.ReadKey();
    }
}