using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStudentService
    {
        Task<Student> Add(Student entity);
        Task<Student> Delete(Student entity);
        Task<Student> Update(Student entity);
        Task<ICollection<Student>> GetList();
        Task<Student> GetById(int id);

        Task<ICollection<StudentDetailViewModel>> GetStudentDetail(int studentId);

    }
}
