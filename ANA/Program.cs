using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design
public class AppDbContext : DbContext
{

    
    public DbSet<Funcionario> Funcionario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=ana_izabella.db");
    }
}

//cadastrar funcionario 
app.MapPost("/funcionario/cadastrar", ([FromBody] Funcionario funcionario) =>
    [FromServices] AppDbContext ctx) =>
{
    ctx.funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);
}



//cadastrar folha 
app.MapPost("/folha/cadastrar", ([FromBody] folha folha) =>
{
    funcionarios.Add(funcionario);
    return Results.Created("", folha);
});

//listar

app.MapGet("/folha/listar", () =>
{
    if (folha.Count > 0)
    {
        return Results.Ok(folha);
    }
    return Results.NotFound();
});

