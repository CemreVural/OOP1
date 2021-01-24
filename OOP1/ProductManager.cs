using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" added.");
           
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");
        }


        ////Void ne oldugunu anlatmak!!
        //public  int Topla(int sayi1, int sayi2)//program akisinda tekrar tekrar kullanilabilir
        //{
        //    return sayi1 + sayi2;
        //} 

        //program.cs'de  

        //int toplamaSonucu = productManager.Topla(2,5); yazdiginda toplar!!

        //Console.Writeline(toplamaSonucu*2); yaptiginda 2 ile carpar.


        //public void Topla2(int sayi1, int sayi2)/// emir kipi yap bitir, bir daha kullanamaz.
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}

    }
}
