using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLayer.Abstract
{
  public  interface IRepository<T> where T:class
    {
        List<T> Listele();
            int Kaydet();
        int Ekle(T entity);
        int Sil(T entity);
        T GetByID(int id);
    }
}
