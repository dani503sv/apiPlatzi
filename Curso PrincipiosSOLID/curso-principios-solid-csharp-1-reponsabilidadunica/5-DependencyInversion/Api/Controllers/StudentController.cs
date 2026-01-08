using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{

    //Inyectamos las dependencias a través del constructor
    IStudentRepository studentRepository;
    ILookbook logbook;

    //Constructor que recibe las dependencias
    public StudentController(IStudentRepository student, ILookbook log)
    {
        this.studentRepository = student;
        this.logbook = log;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
