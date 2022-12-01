using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool_webApi.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina(){}
        public AlunoDisciplina(int alunoId, int disciplinaid) 
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = disciplinaid;
   
        }
                public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}