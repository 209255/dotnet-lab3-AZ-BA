namespace JTTT_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IActions", "ActionName1", c => c.String());
            AddColumn("dbo.IActions", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.IModels", "City", c => c.String());
            AddColumn("dbo.IModels", "TempTrigger", c => c.Single());
        }
        
        public override void Down()
        {
            DropColumn("dbo.IModels", "TempTrigger");
            DropColumn("dbo.IModels", "City");
            DropColumn("dbo.IActions", "Discriminator");
            DropColumn("dbo.IActions", "ActionName1");
        }
    }
}
