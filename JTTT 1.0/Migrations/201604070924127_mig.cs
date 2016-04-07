namespace JTTT_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IModels", "Action_Id", c => c.Int());
            CreateIndex("dbo.IModels", "Action_Id");
            AddForeignKey("dbo.IModels", "Action_Id", "dbo.IActions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IModels", "Action_Id", "dbo.IActions");
            DropIndex("dbo.IModels", new[] { "Action_Id" });
            DropColumn("dbo.IModels", "Action_Id");
        }
    }
}
