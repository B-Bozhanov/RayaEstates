namespace RayaEstates.Data.Models
{
    using RayaEstates.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class Equipment : BaseDeletableModel<int>
    {
        public Equipment()
        {
            this.Properties = new HashSet<Property>();
        }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}