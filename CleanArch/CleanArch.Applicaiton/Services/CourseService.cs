using CleanArch.Applicaiton.Interfaces;
using CleanArch.Applicaiton.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Applicaiton.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
           return new CourseViewModel()
           {
               Courses = _courseRepository.GetCourses()
           };
        }
    }
}
