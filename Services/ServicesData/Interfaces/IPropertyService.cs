namespace RayaEstates.Services.ServicesData.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using RayaEstates.Web.ViewModels.Property;

    public interface IPropertyService
    {
        public int GetAllActiveCount();

        public Task AddAsync(PropertyInputModel propertyModel, string userId);

        public Task EditAsync(PropertyEditViewModel editModel);

        public Task<IEnumerable<PropertyViewModel>> GetActiveUserPropertiesPerPageAsync(string id, int page);

        public Task<IEnumerable<PropertyViewModel>> GetExpiredUserPropertiesPerPageAsync(string id, int page);

        public Task<IEnumerable<PropertyViewModel>> GetAllWithExpiredUserPropertiesPerPage(string id, int page);

        public Task<bool> IsAnyExpiredProperties(string userId);

        public Task<int> GetAllExpiredPropertiesCount();

        public int GetAllActiveUserPropertiesCount(string userId);

        public int GetAllExpiredUserPropertiesCount(string userId);

        public IEnumerable<PropertyViewModel> GetAllByOptionIdPerPage(int optionId, int page);

        public IEnumerable<PropertyViewModel> GetTopNewest(int count);

        public IEnumerable<PropertyViewModel> GetTopMostExpensive(int count);

        public Task<T> GetByIdAsync<T>(int id);

        public Task<T> GetByIdWithExpiredUserPropertiesAsync<T>(int id, string userId);

        public Task<bool> IsUserProperty(int propertyId, string userId);

        public Dictionary<string, List<string>> PropertyValidator(PropertyInputModel property);

        public Task<bool> RemoveByIdAsync(int id);

        public Task<IEnumerable<PropertyViewModel>> SearchAsync(SearchViewModel searchModel);
    }
}
