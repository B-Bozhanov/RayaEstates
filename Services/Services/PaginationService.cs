namespace RayaEstates.Services.Services
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using RayaEstates.Services.Services.Interfaces;
    using RayaEstates.Services.Services.Models;
    using RayaEstates.Web.ViewModels.PaginationModel;

    using static RayaEstates.Common.ExceptionsMessages;
    using static RayaEstates.Common.GlobalConstants;

    public class PaginationService : IPaginationService
    {
        public PaginationViewModel CreatePagination(int itemsCount, int itemsPerPage, int currentPage, string controllerName, string actionName)
        {
            this.ValidateData(itemsCount, itemsPerPage, currentPage, controllerName, actionName);

            var paginationModel = new PaginationModel(itemsCount, itemsPerPage, currentPage, controllerName, actionName);

            return new PaginationViewModel
                {
                    CurrentPage = paginationModel.CurrentPage,
                    FirstPage = paginationModel.FirstPage,
                    LastPage = paginationModel.LastPage,
                    NextPage = paginationModel.NextPage,
                    PreviousPage = paginationModel.PreviousPage,
                    ActionName = paginationModel.ActionName,
                    ControllerName = paginationModel.ControllerName,
                };
        }

        public IEnumerable<T> Pager<T>(IEnumerable<T> TCollection, int currentPage)
        {
            this.ValidateData(TCollection, currentPage);

            TCollection
                .Skip((currentPage - 1) * PropertyConstants.PropertiesPerPage)
                .Take(PropertyConstants.PropertiesPerPage);

            return TCollection;
        }

        private void ValidateData(int itemsCount, int itemsPerPage, int currentPage, string controllerName, string actionName)
        {
            if (itemsCount < 0)
            {
                throw new InvalidOperationException(PaginationServiceExceptions.NegativeItems);
            }
            else if (itemsPerPage <= 0 || itemsPerPage > 100)
            {
                throw new InvalidOperationException(PaginationServiceExceptions.ItemsLimit);
            }
            else if (currentPage <= 0)
            {
                throw new InvalidOperationException(PaginationServiceExceptions.NegativePage);
            }
            else if (controllerName == null || actionName == null)
            {
                throw new InvalidOperationException(PaginationServiceExceptions.NullControllerNameOrActionName);
            }
        }

        private void ValidateData(IEnumerable collection, int currentPage)
        {
            if (collection == null)
            {
                throw new InvalidOperationException(PaginationServiceExceptions.NullCollection);
            }
            else if (currentPage <= 0)
            {
                throw new InvalidOperationException(PaginationServiceExceptions.NegativePage);
            }
        }
    }
}
