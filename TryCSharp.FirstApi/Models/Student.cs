using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryCSharp.FirstApi.Models
{
    public class Student
    {
        // Scalar Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        // Navigation Property
        public Department Department { get; set; }
    }
}
