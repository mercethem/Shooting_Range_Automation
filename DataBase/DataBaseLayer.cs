namespace PoligonOtomasyonu.DataBase
{
    public static class DatabaseConnection
    {
        static string connectionUrl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\ShootRangeAutomation\AutomationProject.mdf"";Integrated Security=True";

        public static string DatabaseUrl()
        {
            return connectionUrl;
        }
    }
}
