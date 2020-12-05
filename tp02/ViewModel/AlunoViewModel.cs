using System;
using tp02.Model;

namespace tp02.ViewModel
{
    class AlunoViewModel
    {
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public AlunoViewModel(Aluno aluno)
        {
            this.RM = aluno.RM;
            this.Nome = aluno.Nome;
            this.Email = aluno.Email;
        }

        public static Aluno GetAluno()
        {
            var aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "542621",
                Nome = "Anderson Silva",
                Email = "anderson@ufc.com"
            };
            return aluno;
        }
    }
}
