namespace DemoLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Khoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        KhoaID = c.String(nullable: false, maxLength: 10),
                        KhoaName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.KhoaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khoas");
        }
    }
}
