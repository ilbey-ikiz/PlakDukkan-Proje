using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlakDukkanıProje.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanilar",
                columns: new[] { "KullaniciID", "Ad", "KullaniciAdi", "Sifre", "Soyad", "Tip" },
                values: new object[] { 1, "Enes", "admin", "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3", "Baba", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanilar",
                keyColumn: "KullaniciID",
                keyValue: 1);
        }
    }
}
