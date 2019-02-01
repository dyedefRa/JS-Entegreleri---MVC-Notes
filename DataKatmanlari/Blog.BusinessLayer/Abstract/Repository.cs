using Blog.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLayer.Abstract
{
    public class Repository<TT> : IRepository<TT> where TT : class
    {
        private DbSet<TT> _objectSet;
        private readonly CTXContext ctx = new CTXContext();
        public Repository()
        {
            _objectSet = ctx.Set<TT>();

        }

        public int Ekle(TT entity)
        {
            _objectSet.Add(entity);
            return Kaydet();
        }

        public TT GetByID(int id)
        {
            return _objectSet.Find(id);
        }

        public int Kaydet()
        {
            return ctx.SaveChanges();
        }

        public List<TT> Listele()
        {
            return _objectSet.ToList();
        }

        public int Sil(TT entity)
        {
           _objectSet.Remove(entity);
            return Kaydet();
        }
    }
}
