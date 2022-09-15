// See https://aka.ms/new-console-template for more information
using System;
namespace BT1
{
class meo
{
        public string ten;
        public string giong;
        public string gioitinh;
        public int tuoi;
        public int dem;
        public void Nhap()
        {
                Console.WriteLine("Nhap ten meo");
                ten = Console.ReadLine();
                Console.WriteLine("Nhap giong");
                giong = Console.ReadLine();
                Console.WriteLine("Nhap gioi tinh");
                gioitinh = Console.ReadLine();
                Console.WriteLine("Nhap tuoi");
                tuoi = int.Parse(Console.ReadLine());
                dem = dem +1;
        }
        public void Xuat()
        {
                Console.WriteLine("Ten meo "+ten);
                Console.WriteLine("Ten giong "+giong);
                Console.WriteLine("Gioi tinh "+gioitinh);
                Console.WriteLine("tuoi "+tuoi);
        }
        ~meo()
        {
                Console.WriteLine("Doi tuong da bi huy");
        }
        class Program
        {
                static void Main(string[] args)
                {
                        meo h = new meo();
                        h.Nhap();
                        h.Xuat();
                        // Console.WriteLine("So luong meo co trong sanh sach:"+dem);
                        Console.ReadLine();
                }
        }
}
}