using ApiFeira.Models;
using ApiFeira.Repositories.Interfaces;

namespace ApiFeira.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private static List<Projeto> projetos = new();
        private static List<Visita> visitas = new();

        public bool AdicionarProjeto(Projeto projeto)
        {
            bool existe = projetos.Any(p =>
                p.Numero == projeto.Numero);

            if (existe)
            {
                return false;
            }

            projetos.Add(projeto);

            return true;
        }

        public List<Projeto> ListarProjetos()
        {
            return projetos;
        }

        public bool RegistrarVisita(Visita visita)
        {
            bool existe = projetos.Any(p =>
                p.Numero == visita.NumeroProjeto);

            if (!existe)
            {
                return false;
            }

            visitas.Add(visita);

            return true;
        }

        public List<Visita> ConsultarVisitas(int numero)
        {
            return visitas
                .Where(v => v.NumeroProjeto == numero)
                .ToList();
        }
    }
}