using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccsess.EntityFramework
{
    //class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    //{
    //    private DbContext _context;
    //    private IDbSet<T> _entities;

    //    EfQueryableRepository(DbContext context)
    //    {
    //        _context = context;
    //    }

    //    public IQueryable<T> Table => this.Entities;

    //    protected IDbSet<T> Entities
    //    {
    //        get
    //        {
    //            if (_entities == null)
    //            {
    //                _entities = _context.Set<T>();
    //            }
    //            return _entities;
    //        }
    //    }
    //}
}
