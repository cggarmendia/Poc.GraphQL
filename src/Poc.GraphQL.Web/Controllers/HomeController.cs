using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Poc.GraphQL.Web.Clients;
using Poc.GraphQL.Web.Models;

namespace Poc.GraphQL.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AirlineGraphClient _airlineGraphClient;

        public HomeController(AirlineGraphClient airlineGraphClient)
        {
            _airlineGraphClient = airlineGraphClient;
        }


        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> AirlineDetail(int airlineId)
        {
            await _airlineGraphClient.SubscribeToUpdates();
            var airline = await _airlineGraphClient.GetAirline(airlineId);
            return View(airline);
        }

        public IActionResult AddReview(int airlineId)
        {
            return View(new AirlineReviewModel { AirlineId = airlineId });
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(AirlineReviewModel reviewModel)
        {
            await _airlineGraphClient.AddReview(reviewModel);
            return RedirectToAction("AirlineDetail", new { reviewModel.AirlineId });
        }
    }
}
