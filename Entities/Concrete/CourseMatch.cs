using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class CourseMatch : IEntity
    {
        public int CourseMatchId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
