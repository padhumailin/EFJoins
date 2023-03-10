using System.ComponentModel.DataAnnotations;

namespace EFJoins.Enity
{
    public class StandardDTO
    {
        [Key]
        public int StandardID { get; set; } 
        public string StandardName { get; set; }
        public string StandardDescription { get; set; }

        public ICollection<StudentDTO> Students { get; set; }

    }
}
