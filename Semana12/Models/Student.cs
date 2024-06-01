using System.Globalization;

namespace Semana12.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Activo { get; set; }

        public int? GradeID { get; set; }
        public Grade Grade { get; set; }
    }

}
