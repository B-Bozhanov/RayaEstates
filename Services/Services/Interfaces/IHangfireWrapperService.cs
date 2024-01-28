namespace RayaEstates.Services.Services.Interfaces
{
    using Hangfire;

    public interface IHangfireWrapperService
    {
        public IBackgroundJobClient BackgroundJobClient { get; }

        public IRecurringJobManagerV2 RecurringJobManager { get; }
    }
}
