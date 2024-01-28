namespace RayaEstates.Common
{
    public static class ExceptionsMessages
    {
        public static class PaginationServiceExceptions
        {
            public const string NegativeItems = "Items can not be negative";
            public const string ItemsLimit = "Items must be between 1 and 100";
            public const string NegativePage = "Current page can not be negative";
            public const string NullControllerNameOrActionName = "Controller name and action name canot be null";
            public const string NullCollection = "The collection can not be null";
        }
    }
}
