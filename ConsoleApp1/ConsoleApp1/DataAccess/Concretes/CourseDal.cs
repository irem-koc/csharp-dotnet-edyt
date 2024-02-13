using ConsoleApp1.DataAccess.Abstracts;
using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new();
        course1.Id = 1;
        course1.Name = "c#";
        course1.Description = "Net8";
        course1.Price = 1;

        Course course2 = new();
        course2.Id = 2;
        course2.Name = "java";
        course2.Description = "backend";
        course2.Price = 10;

        Course course3 = new();
        course3.Id = 3;
        course3.Name = "react";
        course3.Description = "frontend";
        course3.Price = 15;

        courses = new List<Course> { course1,course2,course3};
        //courses[0] = course1;
        //courses[1] = course2;
        //courses[2] = course3;
    }
    public List<Course> GetAll()
    {
        return courses;
        // burada db işlemleri yapılır

    }
    public void Add(Course course)
    {
        courses.Add(course);
    }
    }
