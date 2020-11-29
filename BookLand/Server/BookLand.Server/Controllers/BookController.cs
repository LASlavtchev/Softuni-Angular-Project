namespace BookLand.Server.Controllers
{
    using Models.Books;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BookLand.Server.Infrastructure;

    public class BookController : ApiController
    {
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateRequestModel model)
        {
            var userId = this.User.GetId();

            return Ok(userId);
        }
    }
}
