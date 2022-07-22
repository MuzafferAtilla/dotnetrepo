using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICourseService
    {
        Task<ICollection<Course>> GetList();

    }
}
