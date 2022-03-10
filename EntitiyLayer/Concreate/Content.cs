using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concreate
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        //başlık ile içeripği ilişkilendirdim
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }
        //yazar ile içeriği ilişkilendirdim.
        public int? WriterID { get; set; }//yazarv ile ilişki kuramadığım içim int? yaptım nullable type yapıyorum
        public virtual Writer Writer { get; set; }
    }
}
