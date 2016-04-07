namespace JTTT_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActionId = c.Int(),
                        ReactionId = c.Int(),
                        ActionModelId = c.Int(),
                        ReactionModelId = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IActions", t => t.ActionId)
                .ForeignKey("dbo.IModels", t => t.ActionModelId)
                .ForeignKey("dbo.IReactions", t => t.ReactionId)
                .ForeignKey("dbo.IModels", t => t.ReactionModelId)
                .Index(t => t.ActionId)
                .Index(t => t.ReactionId)
                .Index(t => t.ActionModelId)
                .Index(t => t.ReactionModelId);
            
            CreateTable(
                "dbo.IActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActionName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        URL = c.String(),
                        EmailReceiverAddress = c.String(),
                        ImgURL = c.String(),
                        URL1 = c.String(),
                        KeyWord = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IReactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReactionName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "ReactionModelId", "dbo.IModels");
            DropForeignKey("dbo.Tasks", "ReactionId", "dbo.IReactions");
            DropForeignKey("dbo.Tasks", "ActionModelId", "dbo.IModels");
            DropForeignKey("dbo.Tasks", "ActionId", "dbo.IActions");
            DropIndex("dbo.Tasks", new[] { "ReactionModelId" });
            DropIndex("dbo.Tasks", new[] { "ActionModelId" });
            DropIndex("dbo.Tasks", new[] { "ReactionId" });
            DropIndex("dbo.Tasks", new[] { "ActionId" });
            DropTable("dbo.IReactions");
            DropTable("dbo.IModels");
            DropTable("dbo.IActions");
            DropTable("dbo.Tasks");
        }
    }
}
