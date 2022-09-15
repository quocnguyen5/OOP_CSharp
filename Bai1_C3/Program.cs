using System;
namespace BT1
{
class Sach
{
        public string TenSach;
        public string TacGia;
        public int NamXB;
        public int SoLuong;
        public void Nhap()
        {
                Console.WriteLine("Nhap ten sach");
                TenSach = Console.ReadLine();
                Console.WriteLine("Nhap ten tac gia");
                TacGia = Console.ReadLine();
                Console.WriteLine("Nhap nam XB");
                NamXB = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so luong");
                SoLuong = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
                Console.WriteLine("Ten sach "+TenSach);
                Console.WriteLine("Ten tac gia "+TacGia);
                Console.WriteLine("So luong sach "+SoLuong);
                Console.WriteLine("NamXB "+NamXB);
        }
        ~Sach()
        {
                Console.WriteLine("Doi tuong da bi huy");
        }
        class Program
        {
                static void Main(string[] args)
                {
                        Sach h = new Sach();
                        h.Nhap();
                        h.Xuat();
                        Console.ReadLine();
                }
        }
}
}