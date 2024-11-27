passo a passo

1. models
    Pedido.cs

        [Table("Pedido")]
        public class Pedido
        {
            [Column("Id")]
            [Display(Name = "ID")]
            public int Id { get; set; }


            [Column("CNPJ")]
            [Display(Name = "CNPJ")]
            public int CNPJ { get; set; }



            [Column("Nome do Produto")]
            [Display(Name = "Nome do Produto")]
            public string NomeProduto { get; set; }
        }

    Contexto.cs
        
        public class Contexto : DbContext
        {

            public Contexto(DbContextOptions<Contexto> options) : base(options)
            {
            
            }

            public DbSet<Pedido> Pedido { get; set; }
        }

INSTALAR NUGET

ENTITYCORE
ENTITYCORE.SQLSERVER

2. Program.cs
    var builder = WebApplication.CreateBuilder(args);


    builder.Services.AddControllersWithViews();

    builder.Services.AddDbContext<Contexto>
        (options => options.UseSqlServer ("Data Source=DESKTOP-EAQ2PAQ\\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"));

        ali em catalog é o nome do banco de dados, deixa PIM

3. Controller
    botao direito do mouse -> adicionar -> controller -> MVC controller com views, usando entidade -> preenche com o Pedido e o Contexto

4. Gerenciador de Pacotes
    Add-Migration Inicial-criacao -Context Contexto
    Update-database -Context Contexto

5. Colocando a list em fornecedores
    <a href="@Url.Action("Index", "Pedidos")"></a>

