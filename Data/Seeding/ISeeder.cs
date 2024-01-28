namespace RayaEstates.Data.Seeding
{
    public interface ISeeder
    {
        public Task SeedAsync(EstateDbContext dbContext, IServiceProvider serviceProvider);
    }
}
