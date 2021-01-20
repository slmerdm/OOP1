using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }   //hangi kategoriye ait
        public string ProductName { get; set; }  //ürün ismi
        public double UnitPrice { get; set; }  //ürün fiyatı
        public int UnitsInStock { get; set; }   //stok miktarı


    }
}
