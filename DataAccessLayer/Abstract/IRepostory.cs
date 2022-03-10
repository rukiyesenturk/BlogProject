using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepostory<T>//T entityden gelen başlığı karşılayacak.
    {
        //CRUD
        //Neden Irepostory yaptım sonradan eklemiş olduğum işlemleri tüm başllıklarıma tek tek eklemem gerekmeyecek

        List<T> List();
        void Insert(T p);
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T p);
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter);//ŞArtlı listeleme yapacak mesela yaza radı ali olanları getir.

    }
}
