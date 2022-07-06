using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_to_Object_Mapping.Interface;
using Object_to_Object_Mapping.DTO;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Object_to_Object_Mapping.Database;
using Object_to_Object_Mapping.Enum;
namespace Object_to_Object_Mapping.Service
{
    public class StudentService : DataAccess, IStudentDataProvider
    {
        public List<StudentDTO> GetStudent(int Id)
        {
            var result = new List<StudentDTO>();

            try
            {
                using (IDbConnection con = new SqlConnection(conSchoolDB))
                {
                    con.Open();
                    var param = new DynamicParameters();
                    param.Add("@Id", Id);
                    result = con.Query<StudentDTO>(
                    StudentEnum.GetStudent.ToString(), param, commandType: CommandType.StoredProcedure).ToList();
                }

            }
            catch (Exception ex) { string errMsg = ex.Message; }

            return result;
        }

        public List<StudentDTO> GetStudents()
        {
            var result = new List<StudentDTO>();

            try
            {
                using (IDbConnection con = new SqlConnection(conSchoolDB))
                {
                    con.Open();
                    var param = new DynamicParameters();
                    result = con.Query<StudentDTO>(
                    StudentEnum.GetAllStudents.ToString(), commandType: CommandType.StoredProcedure).ToList();
                }

            }
            catch (Exception ex) { string errMsg = ex.Message; }

            return result;
        }


    }
}
