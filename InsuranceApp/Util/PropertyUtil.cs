using System.Configuration;

namespace Util
{
    public class PropertyUtil
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        }
    }
}
