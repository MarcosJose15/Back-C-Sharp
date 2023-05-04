using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/produtos", (Produto produto) =>{
    RepositorioDeProduto.Add(produto);
    //Padrao status code (POST = CREATED)
    return Results.Created("/produtos" + produto.codigo, produto.codigo);
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
});

app.MapDelete("/produtos/{codigo}", ([FromRoute] string codigo) =>
{
    var meuProdutoSalvo = RepositorioDeProduto.GetBy(codigo);
    RepositorioDeProduto.Remove(meuProdutoSalvo);
});

app.Run();


//Repositorio de dados (Salvar e Obter Produto)
public static class RepositorioDeProduto
{
    public static List<Produto> ListaDeProdutos { get; set; }

    public static void Add(Produto produto)
    {
        if (ListaDeProdutos == null)
            ListaDeProdutos = new List<Produto>();

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