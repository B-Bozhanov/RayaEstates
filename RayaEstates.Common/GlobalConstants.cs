namespace RayaEstates.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "RealEstate";
        public const string AdministratorRoleName = "Administrator";

        public static class PropertyConstants
        {
            public const int PropertiesPerPage = 12;
        }

        // TODO: Move administrators data to json in data folder
        public static List<Administrator> GetAdministrators()
        {
            var administrators = new List<Administrator>
            {
                new Administrator
                {
                    FirstName = "Bozhan",
                    LastName = "Bozhanov",
                    UserName = "DareDeviL88",
                    Password = "123456",
                    Email = "bojanilkov88@gmail.com",
                },
                new Administrator
                {
                    FirstName = "Iliyan",
                    LastName = "Bozhanov",
                    UserName = "Ribkata",
                    Password = "123456789",
                    Email = "iliyan.bojanov@ka1.bg",
                },
            };

            return administrators;
        }
    }
}
