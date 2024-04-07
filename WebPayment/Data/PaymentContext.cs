using Microsoft.EntityFrameworkCore;
using WebPayment.Models;

namespace WebPayment.Data
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) {

        }

        public DbSet<Product> Products { get; set; }
    }
}
