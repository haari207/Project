using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirstdemo
{
    public class IPL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="please ente team id")]

        public int teamid { get; set; }

        [Column("Teamname",TypeName ="varchar")]
        [MaxLength(20,ErrorMessage ="max length should be 20 characters")]
        [Required(ErrorMessage = "please enter team name")] 
        public string Tname { get; set; }


        [Range(10000,30000000,ErrorMessage = "invalid budget")]
        public int Budget { get; set; }
        public string state { get; set; }

        [Column("Captain", TypeName = "varchar")]
        [MaxLength(20)]
        public string cap { get; set; }
                                                                      
    }
}
