using Microsoft.AspNetCore.Mvc;
using task_10.Data;
using Microsoft.EntityFrameworkCore;
namespace task_10.Controllers;

[ApiController]
[Route("product")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        return await _context.Product.ToListAsync();
    }
    [HttpPost]
    public async Task<ActionResult> AddProduct(Product product)
    {
        _context.Product.Add(product);
        await _context.SaveChangesAsync();
        return Ok(product);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _context.Product.FindAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        _context.Product.Remove(product);
        await _context.SaveChangesAsync();

        return NoContent(); // 204 success
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, Product updatedProduct)
    {
        if (id != updatedProduct.Id)
        {
            return BadRequest("ID mismatch");
        }

        var product = await _context.Product.FindAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        // Update fields
        product.Name = updatedProduct.Name;
        product.Price = updatedProduct.Price;

        await _context.SaveChangesAsync();

        return NoContent();
    }

}