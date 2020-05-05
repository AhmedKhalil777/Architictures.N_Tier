using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sample.DAL.Models
{
    public class Table1
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string StringProperty { get; set; }

        [Required]
        [Range(0,100)]
        public float FloatProperty { get; set; }

        //Navigation Property as one to many relationship
        public List<Table2> Tables { get; set; }
    }
}
