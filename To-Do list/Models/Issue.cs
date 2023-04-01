using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace To_Do_list.Models
{
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int PriorityId { get; set; }   
        public virtual Priority? Priority { get; set; }
        
        public int StatusId { get;set; }
        public virtual Status? Status { get; set; }
    }
}
