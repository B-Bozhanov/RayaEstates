namespace RayaEstates.Web.ViewModels.PaginationModel
{
    public class PaginationViewModel
    {
        public int FirstPage { get; set; } 

        public int PreviousPage { get; set; }

        public int CurrentPage { get; set; }

        public int NextPage { get; set; }

        public int LastPage { get; set; }

        public string ControllerName { get; init; } = null!;

        public string ActionName { get; init; } = null!;
    }
}
