namespace ForMeeting.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_ASSOCIADO",
                c => new
                    {
                        IdAssociado = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        CPF = c.String(nullable: false, maxLength: 11, unicode: false),
                        DataDeCadastro = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DataDeNascimento = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        StatusDeAtivacao = c.Int(nullable: false),
                        UsuarioId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IdAssociado)
                .ForeignKey("dbo.TB_USUARIO", t => t.IdAssociado)
                .Index(t => t.IdAssociado)
                .Index(t => t.CPF, unique: true);
            
            CreateTable(
                "dbo.TB_COMENTARIO",
                c => new
                    {
                        IdComentario = c.Guid(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 1000, unicode: false),
                        DataDeCadastro = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        EventoId = c.Guid(nullable: false),
                        AssociadoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IdComentario)
                .ForeignKey("dbo.TB_EVENTO", t => t.EventoId)
                .ForeignKey("dbo.TB_ASSOCIADO", t => t.AssociadoId)
                .Index(t => t.EventoId)
                .Index(t => t.AssociadoId);
            
            CreateTable(
                "dbo.TB_EVENTO",
                c => new
                    {
                        IdEvento = c.Guid(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 80, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 1000, unicode: false),
                        Vitrine = c.Binary(),
                        HorarioDoEvento = c.DateTime(precision: 7, storeType: "datetime2"),
                        DataDeCadastro = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        StatusDoEvento = c.Int(nullable: false),
                        CriadorId = c.Guid(nullable: false),
                        LocalidadeId = c.Guid(nullable: false),
                        CategoriaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IdEvento)
                .ForeignKey("dbo.TB_CATEGORIA", t => t.CategoriaId)
                .ForeignKey("dbo.TB_LOCALIDADE", t => t.LocalidadeId)
                .ForeignKey("dbo.TB_ASSOCIADO", t => t.CriadorId)
                .Index(t => t.CriadorId)
                .Index(t => t.LocalidadeId)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.TB_CATEGORIA",
                c => new
                    {
                        IdCategoria = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80, unicode: false),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            CreateTable(
                "dbo.TB_LOCALIDADE",
                c => new
                    {
                        IdLocalidade = c.Guid(nullable: false, identity: true),
                        NomeDaLocalidade = c.String(nullable: false, maxLength: 80, unicode: false),
                        Logradouro = c.String(nullable: false, maxLength: 200, unicode: false),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(maxLength: 200, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 80, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 7, unicode: false),
                        Referencias = c.String(maxLength: 500, unicode: false),
                        CidadeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IdLocalidade)
                .ForeignKey("dbo.TB_CIDADE", t => t.CidadeId)
                .Index(t => t.CidadeId);
            
            CreateTable(
                "dbo.TB_CIDADE",
                c => new
                    {
                        IdCidade = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80, unicode: false),
                        EstadoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IdCidade)
                .ForeignKey("dbo.TB_ESTADO", t => t.EstadoId)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.TB_ESTADO",
                c => new
                    {
                        IdEstado = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Sigla = c.String(maxLength: 2, unicode: false),
                        PaisId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IdEstado)
                .ForeignKey("dbo.TB_PAIS", t => t.PaisId)
                .Index(t => t.PaisId);
            
            CreateTable(
                "dbo.TB_PAIS",
                c => new
                    {
                        IdPais = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Sigla = c.String(maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.IdPais);
            
            CreateTable(
                "dbo.TB_USUARIO",
                c => new
                    {
                        IdUsuario = c.Guid(nullable: false, identity: true),
                        Senha = c.String(nullable: false, maxLength: 36, unicode: false),
                        Email = c.String(nullable: false, maxLength: 160, unicode: false),
                        Verificado = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UltimaDataDeLogin = c.DateTime(),
                        Papel = c.Int(nullable: false),
                        CodigoDeVerificacao = c.String(nullable: false, maxLength: 6, unicode: false),
                        CodigoDeAtivacao = c.String(nullable: false, maxLength: 4, unicode: false),
                        CodigoDeAutorizacao = c.String(nullable: false, maxLength: 4, unicode: false),
                        DataDoUltimoRequestDoCodigoDeAutorizacao = c.DateTime(),
                        AssociadoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .Index(t => t.Email, unique: true, name: "EmailIndex");
            
            CreateTable(
                "dbo.TB_ASSOCIADO_EVENTO",
                c => new
                    {
                        AssociadoId = c.Guid(nullable: false),
                        EventoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.AssociadoId, t.EventoId })
                .ForeignKey("dbo.TB_ASSOCIADO", t => t.AssociadoId)
                .ForeignKey("dbo.TB_EVENTO", t => t.EventoId)
                .Index(t => t.AssociadoId)
                .Index(t => t.EventoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_ASSOCIADO", "IdAssociado", "dbo.TB_USUARIO");
            DropForeignKey("dbo.TB_ASSOCIADO_EVENTO", "EventoId", "dbo.TB_EVENTO");
            DropForeignKey("dbo.TB_ASSOCIADO_EVENTO", "AssociadoId", "dbo.TB_ASSOCIADO");
            DropForeignKey("dbo.TB_EVENTO", "CriadorId", "dbo.TB_ASSOCIADO");
            DropForeignKey("dbo.TB_COMENTARIO", "AssociadoId", "dbo.TB_ASSOCIADO");
            DropForeignKey("dbo.TB_COMENTARIO", "EventoId", "dbo.TB_EVENTO");
            DropForeignKey("dbo.TB_EVENTO", "LocalidadeId", "dbo.TB_LOCALIDADE");
            DropForeignKey("dbo.TB_LOCALIDADE", "CidadeId", "dbo.TB_CIDADE");
            DropForeignKey("dbo.TB_CIDADE", "EstadoId", "dbo.TB_ESTADO");
            DropForeignKey("dbo.TB_ESTADO", "PaisId", "dbo.TB_PAIS");
            DropForeignKey("dbo.TB_EVENTO", "CategoriaId", "dbo.TB_CATEGORIA");
            DropIndex("dbo.TB_ASSOCIADO_EVENTO", new[] { "EventoId" });
            DropIndex("dbo.TB_ASSOCIADO_EVENTO", new[] { "AssociadoId" });
            DropIndex("dbo.TB_USUARIO", "EmailIndex");
            DropIndex("dbo.TB_ESTADO", new[] { "PaisId" });
            DropIndex("dbo.TB_CIDADE", new[] { "EstadoId" });
            DropIndex("dbo.TB_LOCALIDADE", new[] { "CidadeId" });
            DropIndex("dbo.TB_EVENTO", new[] { "CategoriaId" });
            DropIndex("dbo.TB_EVENTO", new[] { "LocalidadeId" });
            DropIndex("dbo.TB_EVENTO", new[] { "CriadorId" });
            DropIndex("dbo.TB_COMENTARIO", new[] { "AssociadoId" });
            DropIndex("dbo.TB_COMENTARIO", new[] { "EventoId" });
            DropIndex("dbo.TB_ASSOCIADO", new[] { "CPF" });
            DropIndex("dbo.TB_ASSOCIADO", new[] { "IdAssociado" });
            DropTable("dbo.TB_ASSOCIADO_EVENTO");
            DropTable("dbo.TB_USUARIO");
            DropTable("dbo.TB_PAIS");
            DropTable("dbo.TB_ESTADO");
            DropTable("dbo.TB_CIDADE");
            DropTable("dbo.TB_LOCALIDADE");
            DropTable("dbo.TB_CATEGORIA");
            DropTable("dbo.TB_EVENTO");
            DropTable("dbo.TB_COMENTARIO");
            DropTable("dbo.TB_ASSOCIADO");
        }
    }
}
