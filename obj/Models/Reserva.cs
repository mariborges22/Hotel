using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Reserva

    {
        
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        private int _diasreservados=0;
        public int DiasReservados { get=>_diasreservados;
        set{
            while(value==0||value<0){
                throw new Exception("Digite um número válido para os dias de reserva!");
            }
            _diasreservados=value;
        } }

        public Reserva() { }

        public Reserva(int diasreservados, Suite suite){
            DiasReservados=diasreservados;
            suite=suite;
            _preco= diasreservados*suite.valorDiaria;

        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            if(true){
                Hospedes=hospedes;
            } if(Suite.Capacidade<QuantidadedeHospedes()){
                throw new Exception("A capacidade é menor do que o número de hospédes cadastrados ");

            }
        }

        public void CadastrarSuites(Suite suite){
            Suite=suite;
        }
        
        public int  QuantidadedeHospedes(){
            if(Hospedes != null){
            return Hospedes.Count;
    }
            return 0;
    }

            

        
        private decimal _preco;
        public decimal CalcularPrecoTotal { get=>_preco;
         set{
            
             while(value<=0){
                throw new Exception("Insira um valor válido acima de zero!");

             }

             if(_diasreservados>=10){
                Console.WriteLine($"Se vai ficar mais de 10 dias, oferecemos pelo preço de 10% de desconto: {90*value/100} ");
                 
             }
             
              
              
             _preco=value;
             
         } }




        

}
}