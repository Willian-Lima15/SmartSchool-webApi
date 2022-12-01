using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool_webApi.Models
{
    public class Aluno
    {
        public Aluno(){}
        public Aluno(int id, string sobrenome, string nome, string phone) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Phone = phone;
   
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Phone { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; internal set; }
    }
}