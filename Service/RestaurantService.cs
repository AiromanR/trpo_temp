using WebApplication1.Models;

namespace WebApplication1.Service
{
    static public class RestaurantService
    {
        static private WebApiDatabaseContext _db = DBService.Instance.Context;
        static public List<Restaurant> Restaurants = new( );
        //static public Restaurant FindProduct(int id)
        //{
        //    return ;
        //}
        static public List<Restaurant> GetAllRest()
        {
            return _db.Restaurants.ToList( );
        }
        static public Restaurant? Get(int id)
        {
            return _db.Restaurants.Find(id);
        }
    }
}
