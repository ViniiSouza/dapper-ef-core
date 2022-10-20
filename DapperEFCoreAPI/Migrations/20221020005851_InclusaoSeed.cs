using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DapperEFCoreAPI.Migrations
{
    public partial class InclusaoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "DataAlteracao", "DataCadastro", "Descricao", "Nome" },
                values: new object[] { 1, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carnes" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "DataAlteracao", "DataCadastro", "Descricao", "Nome" },
                values: new object[] { 2, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Produtos lácteos" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "DataAlteracao", "DataCadastro", "Descricao", "Nome" },
                values: new object[] { 3, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Produtos de limpeza" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "DataAlteracao", "DataCadastro", "Descricao", "Estoque", "Nome", "Valor" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filé Bovino Simples à vácuo", 500, "Filé Simples", 24.99m },
                    { 2, 1, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filé Bovino duplo à vácuo", 350, "Filé duplo", 38.99m },
                    { 3, 2, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leite integral 1L", 2000, "Leite Integral", 3.69m },
                    { 4, 3, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Água sanitária 5L", 1500, "Água sanitária", 22.69m },
                    { 5, 3, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabão em pó 1.6kg", 850, "Sabão em pó", 23.99m },
                    { 6, 3, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Limpador multiuso 5L", 500, "Limpador multiuso", 31.99m },
                    { 7, 2, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margarina 500g", 1000, "Margarina", 5.99m },
                    { 8, 2, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iogurte integral 170g", 1000, "Iogurte integral", 2.99m },
                    { 9, 1, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carne bovina moída de contra filé resfriada", 350, "Carne bovina moída de contra filé", 36.29m },
                    { 10, 3, null, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lava-Rouaps em Pó 1,6Kg", 1000, "Lava-Roupas em Pó", 21.90m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
