using CleanArch.Applicaiton.ViewModels;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Applicaiton.Interfaces
{
    public interface ICourseService
    {
       CourseViewModel GetCourses();
    }
}
