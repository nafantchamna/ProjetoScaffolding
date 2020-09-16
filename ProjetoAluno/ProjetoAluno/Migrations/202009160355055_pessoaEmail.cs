namespace ProjetoAluno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pessoaEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.pessoas", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.pessoas", "Email");
        }
    }
}
