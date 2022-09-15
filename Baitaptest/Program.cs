
using System;


class Input{
    static void Main(string[] args){
            Console.Write("Ho va ten: ");
            string fullname = Console.ReadLine();
             Console.Write("Lop: ");
            string classmate = Console.ReadLine();

        float[] pointdetail=new float [4];
        Console.Write("Diem_QTH: ");
        for (int i=0; i<1; i++){
            
            pointdetail[i]=float.Parse(Console.ReadLine());
            
        }
        Console.Write("Diem_HTTTQL: ");
        for (int i=1; i<2; i++){
            
            pointdetail[i]=float.Parse(Console.ReadLine());
            
        }
        Console.Write("Diem_CSLT: ");
        for (int i=2; i<3; i++){
            
            pointdetail[i]=float.Parse(Console.ReadLine());
            
        }
        Console.Write("Diem_Triet: ");
        for (int i=3; i<4; i++){
            
            pointdetail[i]=float.Parse(Console.ReadLine());
            
        }
       
        
        float[] thepoint= {0f, 4f, 5.4f, 5.5f, 6.9f, 7f ,8.4f ,8.5f , 10f};
        // for (int i = 0; i < 9; i++){

        //                 Console.WriteLine("The point"+ thepoint[i]);
        // }
        for (int f=0; f< pointdetail.Length; f++){
            if (pointdetail[f]<thepoint[1]){
                pointdetail[f]=0;
                }
        }
        for (int d=0; d< pointdetail.Length; d++){
            if (thepoint[1]<=pointdetail[d] &pointdetail[d]<=thepoint[2]){
                pointdetail[d]=1;
                }
        }
        for (int c=0; c< pointdetail.Length; c++){
            if (thepoint[3]<=pointdetail[c] &pointdetail[c]<=thepoint[4]){
                pointdetail[c]=2;
                }
        }
        for (int b=0; b< pointdetail.Length; b++){
            if (thepoint[5]<=pointdetail[b] &pointdetail[b]<=thepoint[6]){
                pointdetail[b]=3;
                }
        }
        for (int a=0; a< pointdetail.Length; a++){
            if (thepoint[7]<=pointdetail[a] &pointdetail[a]<=thepoint[8]){
                pointdetail[a]=4;
                }
        }
       float GPA=(pointdetail[0]+pointdetail[1]+pointdetail[2]+pointdetail[3])/4; 
        if (3.6<=GPA){
            string rank="Xuat sac";
            Console.WriteLine("Sinh vien "+ fullname+", " +"Lop "+classmate+ ", "+"Dat GPA "+ GPA+", "+"Xep loai "+rank);}
        if (3.2<=GPA & GPA<3.6){
            string rank="Gioi";
            Console.WriteLine("Sinh vien "+ fullname+", " +"Lop "+classmate+ ", "+"Dat GPA "+ GPA+", "+"Xep loai "+rank);}
            
        if (2.5<=GPA & GPA<3.2){
            string rank="Kha";
            Console.WriteLine("Sinh vien "+ fullname+", " +"Lop "+classmate+ ", "+"Dat GPA "+ GPA+", "+"Xep loai "+rank);}
           
        if (2<=GPA & GPA<2.5){
            string rank="Trung binh";
            Console.WriteLine("Sinh vien "+ fullname+", " +"Lop "+classmate+ ", "+"Dat GPA "+ GPA+", "+"Xep loai "+rank);}
           
        if (GPA<2){
            string rank="Yeu";
            Console.WriteLine("Sinh vien "+ fullname+", " +"Lop "+classmate+ ", "+"Dat GPA "+ GPA+", "+"Xep loai "+rank);}
        
            if (3.6<=GPA){

        
        
   
       
        
    }}}
