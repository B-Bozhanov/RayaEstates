namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class Image : BaseDeletableModel<Guid>
    {
        public Image()
        {
            this.Id = Guid.NewGuid();
        }

        [Required]
        public string? Url { get; set; }

        public string? DeleteUrl { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public long Size { get; set; }

        public int Expiration { get; set; }

        [Required]
        public string? Extension { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public virtual Property? Property { get; set; }
    }
}