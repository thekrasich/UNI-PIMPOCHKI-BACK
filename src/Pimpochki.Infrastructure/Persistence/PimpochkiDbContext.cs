using Microsoft.EntityFrameworkCore;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Infrastructure.Persistence;

public class PimpochkiDbContext:DbContext
{
    public PimpochkiDbContext(DbContextOptions<PimpochkiDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         Image[] images = 
        {
            new Image()
            {
                Id = 1,
                ProductId = 1,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2020/05/Ingenico-Desk-5000-Clearly-Payments.png"
            },
            new Image()
            {
                Id = 2,
                ProductId = 1,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2020/05/desk_5000_470_470px_mobile.png"
            },
            new Image()
            {
                Id = 3,
                ProductId = 2,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2020/05/ingenico-move-5000-0.jpg"
            },
            new Image()
            {
                Id = 4,
                ProductId = 2,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2020/05/ingenico-move-5000-contactless.jpg"
            },

            new Image()
            {
                Id = 5,
                ProductId = 3,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2022/06/newland-n910-Clearly-Payments-768x576.jpg"
            },
            new Image()
            {
                Id = 6,
                ProductId = 3,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2021/09/newland-n910-clearly-payments-1-768x432.jpg"
            },

            new Image()
            {
                Id = 7,
                ProductId = 4,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2020/02/Frame-16.png"
            },
            new Image()
            {
                Id = 8,
                ProductId = 4,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2020/07/image2-poynt-5-768x461.jpg"
            },
            new Image()
            {
                Id = 9,
                ProductId = 5,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2022/12/Clover-System-Clearly-Payments-1024x439.png"
            },
            new Image()
            {
                Id = 10,
                ProductId = 5,
                Url = "https://www.clearlypayments.com/wp-content/uploads/2022/12/clover-station-clearly-payments-1024x704.jpg"
            },
            new Image()
            {
                Id = 11,
                ProductId = 6,
                Url = "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/04/s900d.jpg"
            },
            new Image()
            {
                Id = 12,
                ProductId = 6,
                Url = "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/04/s900h.jpg"
            },
            new Image()
            {
                Id = 13,
                ProductId = 7,
                Url = "https://content2.rozetka.com.ua/goods/images/big/361193035.jpg"
            },
            new Image()
            {
                Id = 14,
                ProductId = 7,
                Url = "https://content2.rozetka.com.ua/goods/images/big/361193039.jpg"
            },
            new Image()
            {
                Id = 15,
                ProductId = 8,
                Url = "https://content2.rozetka.com.ua/goods/images/big/361193068.jpg"
            },
            new Image()
            {
                Id = 16,
                ProductId = 8,
                Url = "https://content.rozetka.com.ua/goods/images/big/361193074.jpg"
            },
            new Image()
            {
                Id = 17,
                ProductId = 9,
                Url = "https://content2.rozetka.com.ua/goods/images/big/14942991.jpg"
            },
            new Image()
            {
                Id = 18,
                ProductId = 9,
                Url = "https://content.rozetka.com.ua/goods/images/big/14943024.jpg"
            },
            new Image()
            {
                Id = 19,
                ProductId = 10,
                Url = "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/05/s920.jpg"
            },
            new Image()
            {
                Id = 20,
                ProductId = 10,
                Url = "https://allstarterminals.com/cdn/shop/products/pax-s920-4g-mobile-payment-terminal-347683_1800x1800.webp?v=1696879189"
            }
        };
        Product[] products = 
        {
            new Product()
            {
                Id = 1,
                Name = "Ingenico Desk 5000 Payment Terminal",
                Description = "Accept credit card and debit card payments with the Ingenico Desk 5000 terminal. It’s a perfect countertop payment terminal for offices, retail, restaurants, and other fixed physical locations.",
                Price = 499.99,
                Quantity = 15
            },
            new Product()
            {
                Id = 2,
                Name = "Ingenico Move 5000 Payment Terminal",
                Description = "Accept credit card and debit card payments with the Ingenico Move 5000 credit card machine. It has wireless capabilities to process payments from anywhere.",
                Price = 299.99,
                Quantity = 10
            },
            new Product()
            {
                Id = 3,
                Name = "Newland N910 Credit Card Terminal",
                Description = "The Newland N910 smart payment terminal is compact with wireless 4G Support, wifi connectivity, fast printing, a large printer paper roll. It’s ideal for retail and restaurants.",
                Price = 99.99,
                Quantity = 20
            },
            new Product()
            {
                Id = 4,
                Name = "Poynt Smart Point of Sale System",
                Description = "Accept credit card and debit card payments with the Poynt payment terminal. It’s a perfect countertop payment terminal for offices, retail, restaurants, and other physical locations.",
                Price = 19.99,
                Quantity = 50
            },
            new Product()
            {
                Id = 5,
                Name = "Clover Point-of-Sale Solutions",
                Description = "Clover is a complete point-of-sale system to take payments, track sales, manage employees, and run your business. Built for table and quick-serve restaurants, retail, or service businesses.",
                Price = 199.99,
                Quantity = 8
            },
            new Product()
            {
                Id = 6,
                Name = "S900 Mobile Payment Terminal",
                Description = "PAX S900 is the world most innovative mobile payment terminal powered by a secure operating platform, featuring extended life battery, state of the art colour touch screen and GPRS, WiFi and 3G connectivity. It is the ideal solution for high-end retail and hospitality.",
                Price = 129.99,
                Quantity = 12
            },
            new Product()
            {
                Id = 7,
                Name = "AxagonCRE-SM2 ",
                Description = "The card reader supports all standard formats of contact smart cards, chip cards and other contact cards, including payment cards or contact electronic identification cards *. The reader is compatible with most national eID (electronic ID) programs.",
                Price = 149.99,
                Quantity = 18
            },
            new Product()
            {
                Id = 8,
                Name = "Qoltec",
                Description = "Do you manage a transport company and want to provide your employees with comfortable work thanks to tachographs? Is tracking employee hours a priority for you? If the answer is yes, our chip card scanner is the perfect solution for you.",
                Price = 49.99,
                Quantity = 25
            },
            new Product()
            {
                Id = 9,
                Name = "Zoweetek USB",
                Description = "The Zoweetek USB Smart Card Scanner is a desktop&nbsp;device designed to read chip cards, EMV 4.1 smart cards and 4404, 4428, 4442 and I2C memory cards.&nbsp;",
                Price = 299.99,
                Quantity = 5
            },
            new Product()
            {
                Id = 10,
                Name = "S920 Mobile Payment Terminal",
                Description = "The PAX S920 is the world sleekest compact mobile point of sale terminal, packed with the most complete range of payment industry certifications ever and is manufactured to the highest of global standards using state-of-the-art technology and high-end materials.",
                Price = 999.99,
                Quantity = 3
            }
        };
        
        modelBuilder.Entity<Role>().HasData([
            new Role {Id = 1, UserRole = Application.Enums.Role.Customer.ToString()},
            new Role {Id = 2, UserRole = Application.Enums.Role.Admin.ToString()}
        ]);

        modelBuilder.Entity<Image>().HasData(images);
        modelBuilder.Entity<Product>().HasData(products);

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
}