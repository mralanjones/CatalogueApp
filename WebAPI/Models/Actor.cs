using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string Name { get; set; } = null!;
    }
}
