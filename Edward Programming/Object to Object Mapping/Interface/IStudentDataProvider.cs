using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_to_Object_Mapping.DTO;

namespace Object_to_Object_Mapping.Interface
{
    public interface IStudentDataProvider
    {
        List<StudentDTO> GetStudents();
        List<StudentDTO> GetStudent(int id);
    }
}
