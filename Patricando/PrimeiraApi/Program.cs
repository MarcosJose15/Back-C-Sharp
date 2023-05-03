var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => new {Nome = "Batista Lemos", Idade = 24 });
app.MapGet("/AddHeader", (HttpResponse resposta) => {
    resposta.Headers.Add("Teste", "Batista Lemos");
    return new {Nome = "Batista Lemos", Idade = 24};
});

app.MapPost("/saveproduct", (Produto meuProduto) => {
    return meuProduto.codigo + " - " + meuProduto.Nome;
});

app.Run();


public class Produto{
    public string codigo {get; set;}
    public string Nome {get; set;}
}