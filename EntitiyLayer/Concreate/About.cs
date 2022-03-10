﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concreate
{
    public class About
    {
        [Key]//entityframeworku indirmemiz gerekiyor anahtar koyabilmemiz için
        public int AboutID { get; set; }
        [StringLength(1000)]//ve her bir propumun üzerine max uzunluğunu veriyorum.
        public string AboutDetails1 { get; set; }
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }
        [StringLength(1000)]
        public string AboutImage1 { get; set; }
        [StringLength(1000)]
        public string AboutImage2 { get; set; }
     
    }
}
