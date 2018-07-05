using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCurriculo2.Models
{

    public class Curriculo
    {
        //Informaçoes pessoais
        public int CurriculoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public string Site { get; set; }
        public Estado EstadoCivil { get; set; }
        public Sexo Sexo { get; set; }
        //Endereço
        public string CEP { get; set; }
        public string Endereco { get; set; }
        //Contato
        public string TelefoneFixo { get; set; }
        public string TelefoneMovel { get; set; }
        //Conhecimento
        public string Conhecimento { get; set; }
        public bool HTML { get; set; }
        public bool CSS { get; set; }
        public bool JavaScript { get; set; }
        public string MaisConhecimento { get; set; }


    }
}


