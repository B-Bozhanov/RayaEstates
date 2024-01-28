namespace RayaEstates.Services.Services.Interfaces
{
    using System.Collections.Generic;

    using RayaEstates.Web.ViewModels.PaginationModel;

    public interface IPaginationService
    {
        public PaginationViewModel CreatePagination(int itemsCount,int itemsPerPage, int currentPage, string controllerName, string actionName);

        public IEnumerable<T> Pager<T>(IEnumerable<T> TCollection, int currentPage);
    }
}
