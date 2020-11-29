using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLand.Server.Features.Books
{
    public interface IBookService
    {
        public Task<IEnumerable<string>> GetAll();
    }
}
