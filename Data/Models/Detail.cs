namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class Detail : BaseDeletableModel<int>
    {
        public Detail()
        {
            this.Properties = new HashSet<Property>();
        }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}