﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concreate
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        //category ile ilişkimi oluşturuyorum.
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int WriterID { get; set; }//Yazar ile ilişkimi kurdum.
        public virtual Writer Writer { get; set; }
        //ve heading ile de contant sınıfını ilişkilendireceğim
        public ICollection<Content> Contents { get; set; }
    }
}
