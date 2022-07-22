using System;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class CourseMatchDal : EntityRepositoryBase<CourseMatch, KusysContext>, ICourseMatchDal
    {
        public CourseMatchDal(KusysContext context) : base(context)
        {

        }
    }
}
