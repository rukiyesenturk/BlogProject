﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concreate
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        //ilişki kuracağım
        public ICollection<Heading> Headings { get; set; }//heading sınıfı ile ilişki kuracağım 1 e çok ilişki kuracağım bide bunu heading tarafında belirtmem gerek
    }
}
