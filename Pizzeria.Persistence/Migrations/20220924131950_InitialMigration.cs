using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzeria.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalIngredients",
                columns: table => new
                {
                    AdditionalIngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalIngredients", x => x.AdditionalIngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "BaseIngredients",
                columns: table => new
                {
                    BaseIngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseIngredients", x => x.BaseIngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryAddressAddressId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_DeliveryAddressAddressId",
                        column: x => x.DeliveryAddressAddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaseIngredientPizza",
                columns: table => new
                {
                    BaseIngredientsBaseIngredientId = table.Column<int>(type: "int", nullable: false),
                    PizzasPizzaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseIngredientPizza", x => new { x.BaseIngredientsBaseIngredientId, x.PizzasPizzaId });
                    table.ForeignKey(
                        name: "FK_BaseIngredientPizza_BaseIngredients_BaseIngredientsBaseIngredientId",
                        column: x => x.BaseIngredientsBaseIngredientId,
                        principalTable: "BaseIngredients",
                        principalColumn: "BaseIngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseIngredientPizza_Pizzas_PizzasPizzaId",
                        column: x => x.PizzasPizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinglePizzaOrders",
                columns: table => new
                {
                    SinglePizzaOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentPizzaPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PizzaId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinglePizzaOrders", x => x.SinglePizzaOrderId);
                    table.ForeignKey(
                        name: "FK_SinglePizzaOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_SinglePizzaOrders_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalIngredientSinglePizzaOrder",
                columns: table => new
                {
                    AdditionalIngredientsAdditionalIngredientId = table.Column<int>(type: "int", nullable: false),
                    SinglePizzaOrdersSinglePizzaOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalIngredientSinglePizzaOrder", x => new { x.AdditionalIngredientsAdditionalIngredientId, x.SinglePizzaOrdersSinglePizzaOrderId });
                    table.ForeignKey(
                        name: "FK_AdditionalIngredientSinglePizzaOrder_AdditionalIngredients_AdditionalIngredientsAdditionalIngredientId",
                        column: x => x.AdditionalIngredientsAdditionalIngredientId,
                        principalTable: "AdditionalIngredients",
                        principalColumn: "AdditionalIngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalIngredientSinglePizzaOrder_SinglePizzaOrders_SinglePizzaOrdersSinglePizzaOrderId",
                        column: x => x.SinglePizzaOrdersSinglePizzaOrderId,
                        principalTable: "SinglePizzaOrders",
                        principalColumn: "SinglePizzaOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdditionalIngredients",
                columns: new[] { "AdditionalIngredientId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Kiełbasa", 7m },
                    { 2, "Rukola", 4m }
                });

            migrationBuilder.InsertData(
                table: "BaseIngredients",
                columns: new[] { "BaseIngredientId", "Name" },
                values: new object[,]
                {
                    { 1, "Sos pomidorowy" },
                    { 2, "Ser" },
                    { 3, "Szynka" },
                    { 4, "Pieczarki" }
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "PizzaId", "Description", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Przyszna pizza z szynką", true, "Vesuviana", 25.50m },
                    { 2, "Pyszna pizza z szynką i pieczarkami", true, "Capricciosa", 28m }
                });

            // addded manualy
            migrationBuilder.InsertData(
                table: "BaseIngredientPizza",
                columns: new[] { "BaseIngredientsBaseIngredientId", "PizzasPizzaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalIngredientSinglePizzaOrder_SinglePizzaOrdersSinglePizzaOrderId",
                table: "AdditionalIngredientSinglePizzaOrder",
                column: "SinglePizzaOrdersSinglePizzaOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseIngredientPizza_PizzasPizzaId",
                table: "BaseIngredientPizza",
                column: "PizzasPizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryAddressAddressId",
                table: "Orders",
                column: "DeliveryAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SinglePizzaOrders_OrderId",
                table: "SinglePizzaOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SinglePizzaOrders_PizzaId",
                table: "SinglePizzaOrders",
                column: "PizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalIngredientSinglePizzaOrder");

            migrationBuilder.DropTable(
                name: "BaseIngredientPizza");

            migrationBuilder.DropTable(
                name: "AdditionalIngredients");

            migrationBuilder.DropTable(
                name: "SinglePizzaOrders");

            migrationBuilder.DropTable(
                name: "BaseIngredients");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
