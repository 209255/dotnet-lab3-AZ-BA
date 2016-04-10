namespace JTTT_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IModels", "Description", c => c.String());
            AddColumn("dbo.IModels", "EmailReceiverAddress1", c => c.String());
            AddColumn("dbo.IModels", "ImgURL1", c => c.String());
            AddColumn("dbo.IModels", "Description1", c => c.String());
            AddColumn("dbo.IReactions", "ReactionName1", c => c.String());
            AddColumn("dbo.IReactions", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.IModels", "URL1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IModels", "URL1", c => c.String());
            DropColumn("dbo.IReactions", "Discriminator");
            DropColumn("dbo.IReactions", "ReactionName1");
            DropColumn("dbo.IModels", "Description1");
            DropColumn("dbo.IModels", "ImgURL1");
            DropColumn("dbo.IModels", "EmailReceiverAddress1");
            DropColumn("dbo.IModels", "Description");
        }
    }
}
