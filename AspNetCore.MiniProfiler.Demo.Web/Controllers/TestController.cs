using AspNetCore.MiniProfiler.Demo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.MiniProfiler.Demo.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly IUserRepository UserRepo;

        private readonly IOrderRepository OrderRepo;

        public TestController(IUserRepository userRepo, IOrderRepository orderRepo)
        {
            this.UserRepo = userRepo;
            this.OrderRepo = orderRepo;
        }

        public IActionResult GetUsers(int id)
        {
            return this.Json(this.UserRepo.Get(id));
        }

        public IActionResult GetOrders(int id)
        {
            return this.Json(this.OrderRepo.Get(id));
        }
    }
}