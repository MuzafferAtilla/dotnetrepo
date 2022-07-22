using System;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICourseMatchService
    {
        Task<CourseMatch> Add(CourseMatch entity);

    }
}
