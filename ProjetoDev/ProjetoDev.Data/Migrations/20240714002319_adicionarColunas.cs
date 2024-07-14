using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoDev.Data.Migrations
{
    public partial class adicionarColunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Escolas_EscolaId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Escolas",
                table: "Escolas");

            migrationBuilder.DropColumn(
                name: "EscolaId",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Escolas",
                newName: "tb_Aluno");

            migrationBuilder.AddColumn<string>(
                name: "Ativo",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Situacao",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Aluno",
                table: "tb_Aluno",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Id_Escola",
                table: "Alunos",
                column: "Id_Escola");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_tb_Aluno_Id_Escola",
                table: "Alunos",
                column: "Id_Escola",
                principalTable: "tb_Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_tb_Aluno_Id_Escola",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_Id_Escola",
                table: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Aluno",
                table: "tb_Aluno");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "tb_Aluno",
                newName: "Escolas");

            migrationBuilder.AddColumn<Guid>(
                name: "EscolaId",
                table: "Alunos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Escolas",
                table: "Escolas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos",
                column: "EscolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Escolas_EscolaId",
                table: "Alunos",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id");
        }
    }
}
