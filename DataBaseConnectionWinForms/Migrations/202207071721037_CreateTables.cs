namespace DataBaseConnectionWinForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rostra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Class = c.String(),
                        RostRum_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rostra", t => t.RostRum_Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.RostRum_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BDay = c.DateTime(nullable: false),
                        RostRum_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rostra", t => t.RostRum_Id)
                .Index(t => t.RostRum_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "RostRum_Id", "dbo.Rostra");
            DropForeignKey("dbo.Students", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Students", "RostRum_Id", "dbo.Rostra");
            DropIndex("dbo.Teachers", new[] { "RostRum_Id" });
            DropIndex("dbo.Students", new[] { "Teacher_Id" });
            DropIndex("dbo.Students", new[] { "RostRum_Id" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Rostra");
        }
    }
}
