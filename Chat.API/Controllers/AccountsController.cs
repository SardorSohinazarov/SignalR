﻿using Chat.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAccountsAsync()
        {

            return Ok(new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Account1",
                    CreatedAt = DateTime.Now,
                },
                new Account()
                {
                    Id = 2,
                    Name = "Account2",
                    CreatedAt = DateTime.Now,
                },
            });
        }
    }
}
