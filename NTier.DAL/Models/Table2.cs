using System;
using System.ComponentModel.DataAnnotations;

namespace NTier.DAL.Models
{
    public class Table2
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string StringProperty { get; set; }

        [Required]
        [Range(0, 100)]
        public float FloatProperty { get; set; }


        public Table1 Table { get; set; }
    }
}
