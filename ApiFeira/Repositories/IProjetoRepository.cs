using ApiFeira.Models;

namespace ApiFeira.Repositories.Interfaces
{
    public interface IProjetoRepository
    {
        bool AdicionarProjeto(Projeto projeto);

        List<Projeto> ListarProjetos();

        bool RegistrarVisita(Visita visita);

        List<Visita> ConsultarVisitas(int numero);
    }
}