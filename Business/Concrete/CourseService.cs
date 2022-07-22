using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CourseService : ICourseService
    {

        private readonly ICourseDal _courseDal;
        public CourseService(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public async  Task<ICollection<Course>> GetList()
        {
            return await _courseDal.GetList();
        }
    }
}
