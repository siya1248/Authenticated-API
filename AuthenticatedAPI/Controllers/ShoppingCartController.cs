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

        [HttpPost("remove")]
        public IActionResult RemoveItem(int id)
        {
            var userId = User.Identity.Name;

            var shoppingCart = _context.shoppingCarts
                .Include(cart => cart.products)
                .FirstOrDefault(cart => cart.User == userID);

            if(shoppingCart == null)
            {
                return NotFound();
            }

            var productToRemove = shoppingCart.products.FirstOrDefault(p => p.Id == id);
            if(productToRemove == null)
            {
                return NotFound();
            }
            shoppingCart.products.Remove(productToRemove);
            _context.SaveChanges();
            return NoContent();
        }
    }
}