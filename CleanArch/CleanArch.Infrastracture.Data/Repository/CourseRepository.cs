using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastracture.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infrastracture.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _universityDBContext;
        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _universityDBContext = universityDBContext;   
        }
        public IEnumerable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }
    }
}
