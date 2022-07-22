using System;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Abstract;
using Entities.Concrete;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess.Concrete
{
    public class StudentDal : EntityRepositoryBase<Student, KusysContext>, IStudentDal
    {
        public StudentDal(KusysContext context) : base(context)
        {
            _context = context;
        }



        public async Task<ICollection<StudentDetailViewModel>> GetStudentDetail(int studentId)
        {
            var result = await (from s in _context.Students
                                join cm in _context.CourseMatches on s.StudentId equals cm.StudentId
                                join c in _context.Courses on cm.CourseId equals c.CourseId
                                where s.StudentId == studentId
                                select new StudentDetailViewModel
                                {
                                    FirstName = s.FirstName,
                                    LastName = s.LastName,
                                    CourseName = c.CourseName
                                }).ToListAsync();
            return result;
        }

        public async Task DeleteMatchedCoursees(int studentId)
        {
            var matches = await (from cm in _context.CourseMatches where cm.StudentId == studentId select cm).ToListAsync();
            foreach (var item in matches)
            {
                _context.CourseMatches.Remove(item);
            }
        }
    }
}
