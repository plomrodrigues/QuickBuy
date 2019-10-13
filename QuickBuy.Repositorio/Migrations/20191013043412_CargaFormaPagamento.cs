﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repositorio.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormaPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "Forma de pagamento Boleto", "Boleto" });

            migrationBuilder.InsertData(
                table: "FormaPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "Forma de pagamento cartão de crédito", "Cartão de Crédito" });

            migrationBuilder.InsertData(
                table: "FormaPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 3, "Forma de pagamento depósito", "Depósito" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormaPagamentos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
