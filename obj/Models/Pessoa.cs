using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Pessoa
    {
        public Pessoa(){ }
         public Pessoa(string nome, string sobrenome){
            Nome=nome;
            Sobrenome=sobrenome;
         }

        private string _nome="";
        public string Nome { get=>_nome.ToUpper();
        
        set{
            if(value==""){
                throw new ArgumentException("O nome não pode ser vazio");

            }
            _nome=value;
        }
        
         }
         private string _sobrenome="";
         
         public string Sobrenome { get=> _sobrenome;
         set{
            if(value==""){
                throw new Exception("O sobrenome não pode ser vazio");
            }
            else if(Sobrenome==Nome){
                throw new Exception("O nome não pode ser igual ao sobrenome");
            }
            _sobrenome=value;

         } }
         

    }
}