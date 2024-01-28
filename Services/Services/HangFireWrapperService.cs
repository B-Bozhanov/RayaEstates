namespace RayaEstates.Services.Services
{
    using Hangfire;

    using RayaEstates.Services.Services.Interfaces;

    public class HangFireWrapperService : IHangfireWrapperService
    {
        public IBackgroundJobClient BackgroundJobClient
             => new BackgroundJobClient(JobStorage.Current);

        public IRecurringJobManagerV2 RecurringJobManager
            => new RecurringJobManager();
    }
}
