using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFJoins.Enity
{
    public class StudentDTO
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set;}
        public int StudentRollID { get; set;}

        public string StudentLocation { get; set;}

        [ForeignKey("standard")]
        public int StandardID { get; set;}

       public StandardDTO standard { get; set;}
    }
}
