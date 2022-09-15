class HinhChuNhat
{
        public float Dai;
        public float Rong;
        public void Nhap()
{
        Console.WriteLine("Nhap chieu dai hinh chu nhat :");
        Dai = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong hinh chu nhat :");
        Rong = float.Parse(Console.ReadLine());
}
        public void Xuat()
{
        Console.WriteLine("Hinh chu nhat: Dai = {0}, Rong = {1}",Dai, Rong);
}
        public float Chuvi()
{
        return (Dai+Rong)*2;
}
class Program
{
static void Main(string[] args)
{
HinhChuNhat h = new HinhChuNhat();
h.Nhap();
h.Xuat();
Console.WriteLine("Chu vi HCN: {0}",h.Chuvi());
Console.ReadLine();
}
}
}