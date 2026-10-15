using WebApplication1.Models;

namespace WebApplication1.Service

{
    public class DBService
    {
        private WebApiDatabaseContext context;
        public WebApiDatabaseContext Context => context;
        private static DBService? instance;
        public static DBService Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBService( );
                return instance;
            }
        }
        private DBService ()
        {
            context = new WebApiDatabaseContext( );
        }
    }
}
