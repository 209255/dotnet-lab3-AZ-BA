namespace JTTT_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tasks", name: "ActionId", newName: "Action_Id");
            RenameColumn(table: "dbo.Tasks", name: "ActionModelId", newName: "ActionModel_Id");
            RenameColumn(table: "dbo.Tasks", name: "ReactionId", newName: "Reaction_Id");
            RenameColumn(table: "dbo.Tasks", name: "ReactionModelId", newName: "ReactionModel_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_ActionId", newName: "IX_Action_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_ActionModelId", newName: "IX_ActionModel_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_ReactionId", newName: "IX_Reaction_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_ReactionModelId", newName: "IX_ReactionModel_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Tasks", name: "IX_ReactionModel_Id", newName: "IX_ReactionModelId");
            RenameIndex(table: "dbo.Tasks", name: "IX_Reaction_Id", newName: "IX_ReactionId");
            RenameIndex(table: "dbo.Tasks", name: "IX_ActionModel_Id", newName: "IX_ActionModelId");
            RenameIndex(table: "dbo.Tasks", name: "IX_Action_Id", newName: "IX_ActionId");
            RenameColumn(table: "dbo.Tasks", name: "ReactionModel_Id", newName: "ReactionModelId");
            RenameColumn(table: "dbo.Tasks", name: "Reaction_Id", newName: "ReactionId");
            RenameColumn(table: "dbo.Tasks", name: "ActionModel_Id", newName: "ActionModelId");
            RenameColumn(table: "dbo.Tasks", name: "Action_Id", newName: "ActionId");
        }
    }
}
