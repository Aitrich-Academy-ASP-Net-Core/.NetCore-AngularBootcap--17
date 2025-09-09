using JobSeekerManagement.Dto;
using JobSeekerManagement.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekerManagement.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUserService _userService;

        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Load profile
        public async Task<IActionResult> MyProfile()
        {
            var uid = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(uid))
                return RedirectToAction("Login", "Public");

            if (!int.TryParse(uid, out int userId))
                return RedirectToAction("Login", "Public");

            var profile = await _userService.GetProfileAsync(userId);
            return View(profile); // @model ProfileDto
        }

        // POST: Save profile
        [HttpPost]
        public async Task<IActionResult> MyProfile(ProfileDto model)
        {
            if (ModelState.IsValid)
            {
                var uid = HttpContext.Session.GetString("UserId");
                if (string.IsNullOrEmpty(uid) || !int.TryParse(uid, out int userId))
                    return RedirectToAction("Login", "Public");

                model.UserId = userId; // make sure ProfileDto has UserId
                await _userService.UpdateProfileAsync(model);
                ViewBag.Message = "Profile updated successfully!";
            }
            return View(model);
        }
    }
}
