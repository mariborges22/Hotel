using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Suite

    {
        public Suite(){ }
        public Suite(string tiposuite, int  capacidade, decimal valordiaria){
            TipoSuite=tiposuite;
            Capacidade=capacidade;
            valorDiaria=valordiaria;

            

        }
        private string _tiposuite="";
        public string TipoSuite { get=>_tiposuite; set{
            if(value==""){
                throw new Exception("Digite um tipo válido para a suíte de sua escolha");
            }
            _tiposuite=value;
        } }

        private int _capacidade;

        public int Capacidade { get=>_capacidade; set{
            if(value==0){
                throw new ArgumentNullException("O valor da capacidade suíte é diferente de zero");
            }

            else if(value<0){
                throw new Exception("O valor da capacidade suíte não pode ser menor que zero");
            }

            else if(value>4){
                throw new Exception("A capacidade máxima das suítes é de 4 pessoas");
            }
            _capacidade=value;

        } }
        private decimal _valordiaria;

        public decimal valorDiaria { get=>_valordiaria; set{
            while(value==0||value<0){
                throw new Exception("O preço da diária não pode ser igual e nem menor que zero");

            }
            _valordiaria=value;
        } }
    }
}