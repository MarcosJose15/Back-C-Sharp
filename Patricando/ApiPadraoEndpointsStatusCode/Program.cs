using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/produtos", (Produto produto) =>{
    RepositorioDeProduto.Add(produto);
    //Padrao status code (POST = CREATED)
    return Results.Created($"/produtos{produto.codigo}", produto.codigo);
});

//api.app.com/user/{code}
app.MapGet("/produtos/{code}", ([FromRoute] string codigo) => {
    var produto = RepositorioDeProduto.GetBy(codigo);
    if(produto != null)
    //Padrao status code (GET = OBTER)
        return Results.Ok(produto);
    //Get não encontrado(Status 404 - Not Found)
    return Results.NotFound();
});

app.MapPut("/produtos", (Produto produto) =>
{
    var meuProdutoSalvo = RepositorioDeProduto.GetBy(produto.codigo);
    meuProdutoSalvo.Nome = produto.Nome;
    //Return status 200 - Ok
    return Results.Ok();
});

app.MapDelete("/produtos/{codigo}", ([FromRoute] string codigo) =>
{
    var meuProdutoSalvo = RepositorioDeProduto.GetBy(codigo);
    RepositorioDeProduto.Remove(meuProdutoSalvo);
    //Return status 200 - Ok
    return Results.Ok();
});


//Achar Banco de dados
app.MapGet("/configuration/database", (IConfiguration configuration) => {
    return Results.Ok($"{configuration["database:connection"]}/{configuration["database:port"]}");
});

app.Run();


//Repositorio de dados (Salvar e Obter Produto)
public static class RepositorioDeProduto
{
    public static List<Produto> ListaDeProdutos { get; set; } = ListaDeProdutos = new List<Produto>();

    public static void Add(Produto produto)
    {
        ListaDeProdutos.Add(produto);
    }
    public static Produto GetBy(string codigo)
    {
        return ListaDeProdutos.First(p => p.codigo == codigo);
    }
    public static void Remove(Produto produto)
    {
        ListaDeProdutos.Remove(produto);
    }
}




public class Produto
{
    public string codigo { get; set; }
    public string Nome { get; set; }
}