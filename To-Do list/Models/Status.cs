using System.ComponentModel.DataAnnotations;

namespace To_Do_list.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Issue> Issues { get; set; }
    }
}
