using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryCSharp.FirstApi.Models
{
    public class Department
    { 
        // Scalar Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        // Navigation Property
        public List<Student> Students { get; set; }

    }
}
