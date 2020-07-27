using API.Domain;
using API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service
{
    public class AlunoService : IAlunoService
    {
        public IAluno_Repository aluno_Repository;

        public AlunoService()
        {
        }

        public AlunoService(IAluno_Repository aluno_Repository)
        {
           aluno_Repository = aluno_Repository;
        }
        public List<Aluno> Listar()
        {
            AlunoRepository alunorepository = new AlunoRepository();
            List <Aluno> alunos = alunorepository.Listar();
            
            foreach (var aluno in alunos)
            {
                aluno.NomeCompleto = $"{ aluno.Nome} { aluno.SobreNome}";
            }
            
            return alunos;
        }
    }
}
