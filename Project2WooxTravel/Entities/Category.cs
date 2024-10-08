using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project2WooxTravel.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        [StringLength(100)]  //Kategori Name 100 Karakter olarak kisitlar
        public string CategoryName { get; set; }
        public string CategoryStatus { get; set; }
    }
}