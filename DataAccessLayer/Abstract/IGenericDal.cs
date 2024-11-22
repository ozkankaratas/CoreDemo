using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // Her bir interface için tek bir interface ile generic hale getirdik.
    // Burada yapılan değişiklik, diğer tüm interfaceleri etkileyecek.
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAll();
        T GetByID(int id);
    }
}
