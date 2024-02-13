using ConsoleApp1.DataAccess.Abstracts;
using ConsoleApp1.DataAccess.Concretes;
using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business;

public class CourseManager
{
    //dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {

        //BU KATMANLAR BİRBİRİNİ NEWLEYEMEZ
        //business rules
        return _courseDal.GetAll();
    }
}
