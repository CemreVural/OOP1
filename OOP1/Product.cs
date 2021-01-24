using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//for in key= siralama icin degil güzel okunsun diye yapilir.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD operations= Create Read Update Delete Operations (Otomasyon Projeleri)

    }
}
