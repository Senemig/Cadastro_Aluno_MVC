using System.Collections.Generic;

namespace Média_Aluno_MVC.Models
{
    public static class ListaAlunos
    {
        private static List<Aluno> lista;

        static ListaAlunos()
        {
            lista = new List<Aluno>();
        }

        public static void IncluirAluno(Aluno aluno)
        {
            lista.Add(aluno);
        }

        public static List<Aluno> ListarAlunos()
        {
            return lista;
        }
    }
}