using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstassignment
{
   public class Employee
    {
       
            [Key]
            [Column("Empid", TypeName = "varchar")]
            [MaxLength(10)]
            [RegularExpression(@"^E\d{3}$", ErrorMessage = "Empid must start with E letter followed by 3 digits")]
            [Required(ErrorMessage = "Empid is required")]
            public string Empid { get; set; }

            [Column("EmpName", TypeName = "varchar")]
            [MaxLength(20)]
            public string EmpName { get; set; }

            [ForeignKey("Deptid")]
            public virtual department Department { get; set; }
            public int Deptid { get; set; }

            [Range(50000,150000, ErrorMessage = "Salary must be between 50000 and 150000")]
            public int salary { get; set; }

            public DateTime DOB { get; set; }
        



    }
}
