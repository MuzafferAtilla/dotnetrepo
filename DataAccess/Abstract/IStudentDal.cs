using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IStudentDal : IEntityRepository<Student>
    {
        Task<ICollection<StudentDetailViewModel>> GetStudentDetail(int studentId);

        Task DeleteMatchedCoursees(int studentId);
    }
}
