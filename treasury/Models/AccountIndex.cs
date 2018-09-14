using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace treasury.Models
{
    [Table("AccountIndex",Schema ="Dom")]
    public class AccountIndex
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string EnName{ get; set; }

        [ForeignKey("Childs")]
        public int? ParentId { get; set; }
        public virtual List<AccountIndex> Childs{ get; set; }
    }
}