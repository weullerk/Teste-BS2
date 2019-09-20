using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

// Comentários
//
// DDD: Classe de Cliente - Dominio Principal
// Somente as informações necessárias do cliente são definidas, 
// sendo indiferente se é Pessoa Física ou Júridica. 
//
// S.O.L.I.D: 
//
// Single Responsiblity Principle:
// A entidade cliente só tem a responsabilidade de prover as informações 
// necessárias para o que serão utilizadas no dominio principal.
//
// Open-Closed Principle:
// A interface define o documento de forma generica, podendo ser CPF ou CNPJ.
// Isso atende a necessidade atual, e permite que ela seja extendida para
// adicionar uma informação a mais sem que haja necessidade de modificar o que
// funciona no dominio e sem quebrar as os contextos que tem dependencia no 
// dominio do cliente.
//
// Liskov Substitution Principle:
// Outra classe derivada dessa entidade pode ser utilizada no lugar em que essa é utilizada,
// estando disponivel uma interface ICliente para firmar o contrato e evitar que algum
// comportamento inesperado
//
// Interface Segregation Principle:
// Interface esperifica para ser utilizada no dominio e passivel de extensão.
//
// Dependency Inversion Principle:
// NA
    
// Como esse é um crud simples, a entidade do cliente possui somente os atributos,
// mas poderia conter outros métodos que manipulavam o estado do dominio,
// como solicitar um cartão para o cliente, fazer um emprestimo, etc..

namespace Domain.Models.Cliente
{
    public class Cliente : IAggregateRoot

    {
        public int Codigo { get; private set; }

        public virtual string Nome { get; private set; }

        public virtual string Documento { get; private set; }

        public string Telefone { get; private set; }

        public Endereco Endereco { get; private set; }

        public Cliente(string nome, string documento, string telefone, Endereco endereco)
        {
            this.Nome = nome;
            this.Documento = documento;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }
    }
}
