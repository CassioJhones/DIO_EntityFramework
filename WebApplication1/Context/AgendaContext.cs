using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Context;

public class AgendaContext : DbContext
{//centraliza as informaçoes do banco de dados
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {//Construtor Vazio Padrão

    }
    public DbSet<Contato> Contatos { get; set; }

}
 