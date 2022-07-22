using System;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICourseMatchDal : IEntityRepository<CourseMatch>
    {
    }
}
