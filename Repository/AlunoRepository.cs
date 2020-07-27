using API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain
{
    public class AlunoRepository : IAluno_Repository
    {
        public List <Aluno> Listar ()
        {
            List < Aluno > alunos = new List<Aluno>();

            Aluno aluno = new Aluno();
            aluno.ID = 1;
            aluno.Nome = "Bruna";
            aluno.SobreNome = "Yoshie";
            aluno.Matricula = "123";
            aluno.DataNascimento = new DateTime(1987, 12, 14);
            alunos.Add(aluno);

            aluno = new Aluno();
            aluno.ID = 1;
            aluno.Nome = "Maria";
            aluno.SobreNome = "silva";
            aluno.Matricula = "123";
            aluno.DataNascimento = new DateTime(2003, 11, 25);
            alunos.Add(aluno);

            aluno = new Aluno();
            aluno.ID = 1;
            aluno.Nome = "João";
            aluno.SobreNome = "souza";
            aluno.Matricula = "123";
            aluno.DataNascimento = new DateTime(2009, 5, 10);
            alunos.Add(aluno);

            return alunos;
        }
    }
}
