﻿using Microsoft.AspNetCore.Mvc;
using WebMusic.BLL.DTO;
using WebMusic.BLL.Interfaces;
using WebMusic.BLL.Services;

namespace WebMusic.Controllers
{
    public class UserController : Controller
    {
        private readonly IMediaService _mediaService;
        private readonly IUserService _userService;
        public UserController(IUserService userService, IMediaService mediaService)
        {
            _userService = userService;
            

        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task <IActionResult> AllUsers() 
        {
            return View(await _userService.GetUsers());
        }
        public async Task <IActionResult> ChangeStatus(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

             _userService.UpdateUser(userDTO);


            return RedirectToAction("Index", "Home");
          
        }
    }
}
