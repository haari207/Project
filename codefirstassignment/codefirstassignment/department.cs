using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstassignment
{
   public class department
    {
        [Key]
        [Required(ErrorMessage ="Department ID is required")]
        public int Deptid { get; set; }
        [Column("DepartmentName", TypeName = "varchar")]
        [MaxLength(20)]
        [RegularExpression("^(Finance|HR)$", ErrorMessage = "Department Name must be finance or hr")]
        public string DeptName { get; set; }

        [Column("Manager", TypeName = "varchar")]
        [MaxLength(20)]
        public string Manager { get; set; }

        [Column("Departmentedit", TypeName = "Timestamp")]
        [Timestamp]
        public byte[] Deptedit { get; set; }
    }
}
