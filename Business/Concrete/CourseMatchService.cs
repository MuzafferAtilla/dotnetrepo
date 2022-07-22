using System;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CourseMatchService : ICourseMatchService
    {
        private readonly ICourseMatchDal _courseMatchDal;

        public CourseMatchService(ICourseMatchDal courseMatchDal)
        {
            _courseMatchDal = courseMatchDal;
        }


        public async Task<CourseMatch> Add(CourseMatch entity)
        {
            return await _courseMatchDal.Add(entity);
        }
    }
}
