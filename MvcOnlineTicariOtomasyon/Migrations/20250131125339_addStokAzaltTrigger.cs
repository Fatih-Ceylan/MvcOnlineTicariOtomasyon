using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class addStokAzaltTrigger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE TRIGGER ARTTIR
            ON SatisHareketleri
            AFTER INSERT
            AS
            BEGIN
                -- Satış yapılan ürünlerin stoklarını azalt
                DECLARE @UrunId INT, @Adet INT;
            
                -- Insert edilen tüm satırları almak için
                DECLARE satis_cursor CURSOR FOR
                SELECT UrunId, Adet
                FROM inserted;
            
                OPEN satis_cursor;
                FETCH NEXT FROM satis_cursor INTO @UrunId, @Adet;
            
                -- Cursor üzerinden geçerek her ürün için stok güncellemesi yapılır
                WHILE @@FETCH_STATUS = 0
                BEGIN
                    UPDATE Urun
                    SET Stok = Stok - @Adet
                    WHERE UrunId = @UrunId;
            
                    FETCH NEXT FROM satis_cursor INTO @UrunId, @Adet;
                END;
            
                CLOSE satis_cursor;
                DEALLOCATE satis_cursor;
            END;
            "
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER SatisStokAzalt ON SatisHareketleri;");
        }
    }
}
