namespace BookLand.Server.Features.Books
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Infrastructure.Extensions;
    using Features.Books.Models;

    public class BookController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<int>> Create(CreateRequestModel model)
        {
            var userId = this.User.GetId();

            return Ok(userId);
        }
    }
}
