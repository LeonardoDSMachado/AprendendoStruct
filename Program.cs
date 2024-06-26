Cliente cliente = new();

cliente.Nome = "Leonardo";
cliente.Email = "leonardo.machado@dev.com";
cliente.Idade = 16;

cliente.Exibir(cliente.Nome, cliente.Email, cliente.Idade);
Cliente.ExibirInfo(cliente.Nome, cliente.Email);

Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
                idade = 18;
            else
                idade = value;
        }
    }

    public void Exibir(string? nome, string? email, int idade)
    {
        Console.WriteLine($"Nome : {nome} \nEmail : {email} \nidade :{idade}\n");
    }

    public static void ExibirInfo(string? nome, string? email, int idade = 99)
    {
        Console.WriteLine($"Nome : {nome} \nEmail : {email} \nidade : {idade}");
    }

}

