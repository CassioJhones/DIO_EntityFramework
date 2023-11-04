namespace WebApplication1.Entities;
public class Contato
{//será uma tabela Contatos com as colunas abaixo
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Telefone { get; set; }
    public bool Ativo { get; set; }
}
