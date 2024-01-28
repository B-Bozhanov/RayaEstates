namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class UserContact : BaseDeletableModel<string>
    {
        public UserContact()
        {
            this.Properties = new HashSet<Property>();
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string? Names { get; set; } = null!;

        [Required]
        public string? Email { get; set; } = null!;

        [Required]
        public string? PhoneNumber { get; set; } = null!;

        public virtual ICollection<Property> Properties { get; set; }
    }
}