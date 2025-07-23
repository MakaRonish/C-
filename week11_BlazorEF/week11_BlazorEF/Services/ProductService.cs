using Microsoft.EntityFrameworkCore;
using week11_BlazorEF.Data;
using week11_BlazorEF.Models;

namespace week11_BlazorEF.Services
{
    public class ProductService
    {
        AppDbContext _dbContext;
        public ProductService(AppDbContext context) {
            _dbContext= context;
        }
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
