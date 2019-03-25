namespace ConsoleBd
{

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    [Table("ClassData")]
    public partial class ClassData
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ResaltClass { get; set; }
    }
}
