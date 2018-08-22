namespace crudDatosPersonales.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbEstudiantes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.datosPersonales", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.datosPersonales", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.datosPersonales", "Direccion", c => c.String(nullable: false));
            AlterColumn("dbo.datosPersonales", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.datosPersonales", "Telefono", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.datosPersonales", "Telefono", c => c.String());
            AlterColumn("dbo.datosPersonales", "Email", c => c.String());
            AlterColumn("dbo.datosPersonales", "Direccion", c => c.String());
            AlterColumn("dbo.datosPersonales", "Apellido", c => c.String());
            AlterColumn("dbo.datosPersonales", "Nombre", c => c.String());
        }
    }
}
