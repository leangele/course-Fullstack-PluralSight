using FullStack.net.PluralSight.Persistence;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using FullStack.net.PluralSight.Core;

namespace FullStack.net.PluralSight.Controllers
{
    public class FolloweesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FolloweesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var artists = _unitOfWork.Followings.GetFollowingsList(userId);

            return View(artists);
        }


    }
}
