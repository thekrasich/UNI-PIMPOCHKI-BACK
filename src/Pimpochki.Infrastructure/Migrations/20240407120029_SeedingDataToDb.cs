using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pimpochki.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Accept credit card and debit card payments with the Ingenico Desk 5000 terminal. It’s a perfect countertop payment terminal for offices, retail, restaurants, and other fixed physical locations.", "Ingenico Desk 5000 Payment Terminal", 499.99000000000001, 15 },
                    { 2, "Accept credit card and debit card payments with the Ingenico Move 5000 credit card machine. It has wireless capabilities to process payments from anywhere.", "Ingenico Move 5000 Payment Terminal", 299.99000000000001, 10 },
                    { 3, "The Newland N910 smart payment terminal is compact with wireless 4G Support, wifi connectivity, fast printing, a large printer paper roll. It’s ideal for retail and restaurants.", "Newland N910 Credit Card Terminal", 99.989999999999995, 20 },
                    { 4, "Accept credit card and debit card payments with the Poynt payment terminal. It’s a perfect countertop payment terminal for offices, retail, restaurants, and other physical locations.", "Poynt Smart Point of Sale System", 19.989999999999998, 50 },
                    { 5, "Clover is a complete point-of-sale system to take payments, track sales, manage employees, and run your business. Built for table and quick-serve restaurants, retail, or service businesses.", "Clover Point-of-Sale Solutions", 199.99000000000001, 8 },
                    { 6, "PAX S900 is the world most innovative mobile payment terminal powered by a secure operating platform, featuring extended life battery, state of the art colour touch screen and GPRS, WiFi and 3G connectivity. It is the ideal solution for high-end retail and hospitality.", "S900 Mobile Payment Terminal", 129.99000000000001, 12 },
                    { 7, "The card reader supports all standard formats of contact smart cards, chip cards and other contact cards, including payment cards or contact electronic identification cards *. The reader is compatible with most national eID (electronic ID) programs.", "AxagonCRE-SM2 ", 149.99000000000001, 18 },
                    { 8, "Do you manage a transport company and want to provide your employees with comfortable work thanks to tachographs? Is tracking employee hours a priority for you? If the answer is yes, our chip card scanner is the perfect solution for you.", "Qoltec", 49.990000000000002, 25 },
                    { 9, "The Zoweetek USB Smart Card Scanner is a desktop&nbsp;device designed to read chip cards, EMV 4.1 smart cards and 4404, 4428, 4442 and I2C memory cards.&nbsp;", "Zoweetek USB", 299.99000000000001, 5 },
                    { 10, "The PAX S920 is the world sleekest compact mobile point of sale terminal, packed with the most complete range of payment industry certifications ever and is manufactured to the highest of global standards using state-of-the-art technology and high-end materials.", "S920 Mobile Payment Terminal", 999.99000000000001, 3 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://www.clearlypayments.com/wp-content/uploads/2020/05/Ingenico-Desk-5000-Clearly-Payments.png" },
                    { 2, 1, "https://www.clearlypayments.com/wp-content/uploads/2020/05/desk_5000_470_470px_mobile.png" },
                    { 3, 2, "https://www.clearlypayments.com/wp-content/uploads/2020/05/ingenico-move-5000-0.jpg" },
                    { 4, 2, "https://www.clearlypayments.com/wp-content/uploads/2020/05/ingenico-move-5000-contactless.jpg" },
                    { 5, 3, "https://www.clearlypayments.com/wp-content/uploads/2022/06/newland-n910-Clearly-Payments-768x576.jpg" },
                    { 6, 3, "https://www.clearlypayments.com/wp-content/uploads/2021/09/newland-n910-clearly-payments-1-768x432.jpg" },
                    { 7, 4, "https://www.clearlypayments.com/wp-content/uploads/2020/02/Frame-16.png" },
                    { 8, 4, "https://www.clearlypayments.com/wp-content/uploads/2020/07/image2-poynt-5-768x461.jpg" },
                    { 9, 5, "https://www.clearlypayments.com/wp-content/uploads/2022/12/Clover-System-Clearly-Payments-1024x439.png" },
                    { 10, 5, "https://www.clearlypayments.com/wp-content/uploads/2022/12/clover-station-clearly-payments-1024x704.jpg" },
                    { 11, 6, "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/04/s900d.jpg" },
                    { 12, 6, "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/04/s900h.jpg" },
                    { 13, 7, "https://content2.rozetka.com.ua/goods/images/big/361193035.jpg" },
                    { 14, 7, "https://content2.rozetka.com.ua/goods/images/big/361193039.jpg" },
                    { 15, 8, "https://content2.rozetka.com.ua/goods/images/big/361193068.jpg" },
                    { 16, 8, "https://content.rozetka.com.ua/goods/images/big/361193074.jpg" },
                    { 17, 9, "https://content2.rozetka.com.ua/goods/images/big/14942991.jpg" },
                    { 18, 9, "https://content.rozetka.com.ua/goods/images/big/14943024.jpg" },
                    { 19, 10, "http://genie2go.com/demo/genie2go/wp-content/uploads/2017/05/s920.jpg" },
                    { 20, 10, "https://allstarterminals.com/cdn/shop/products/pax-s920-4g-mobile-payment-terminal-347683_1800x1800.webp?v=1696879189" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
