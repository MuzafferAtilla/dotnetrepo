using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IStudentDal _studentDal;

        public StudentService(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }


        public async Task<Student> Add(Student entity)
        {
            return await _studentDal.Add(entity);
        }

        public async Task<Student> Delete(Student entity)
        {
            await _studentDal.DeleteMatchedCoursees(entity.StudentId);
            return await _studentDal.Delete(entity);
        }

        public async Task<Student> GetById(int id)
        {
            return await _studentDal.GetById(m => m.StudentId == id);
        }

        public async Task<ICollection<Student>> GetList()
        {
            return await _studentDal.GetList();
        }

        public async Task<ICollection<StudentDetailViewModel>> GetStudentDetail(int studentId)
        {
            return await _studentDal.GetStudentDetail(studentId);
        }

        public async Task<Student> Update(Student entity)
        {
            return await _studentDal.Update(entity);
        }
    }
}
