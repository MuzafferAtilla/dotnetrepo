using System;
using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class CourseDal : EntityRepositoryBase<Course, KusysContext>, ICourseDal
    {
        public CourseDal(KusysContext context) : base(context)
        {

        }
    }
}
