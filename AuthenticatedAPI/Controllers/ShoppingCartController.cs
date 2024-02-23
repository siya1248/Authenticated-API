using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace AuthenticatedAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly SecurityContext _context'
        public ShoppingCartController(SecurityContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var userId = User.Identity.Name;

            var shoppingCartItems = _context.shoppingCarts
            .Where(cart => cart.User == userId)
            .SelectMany(cart => cart.products)
            .ToList();

            return Ok(shoppingCartItems);
        }
    }
}