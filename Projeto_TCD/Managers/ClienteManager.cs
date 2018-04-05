using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCD.Managers
{ 
    public class ClienteManager
    {
        public static void Adicionar(string nome, string tipo, string cpf, string rg, string dtnasc, string sexo, string email, string rua, string bairro, string numero, string compl, string cidade, string estado, string telefone)
        {
            
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                Cliente cliente = new Cliente();
                cliente.NomeCliente = nome;
                cliente.TipoCliente = tipo;
                cliente.CPF = cpf;
                cliente.RG = rg;
                cliente.DataNascimento = dtnasc;
                cliente.Sexo = sexo;
                cliente.Email = email;
                cliente.Rua = rua;
                cliente.Bairro = bairro;
                cliente.Numero = numero;
                cliente.Complemento = compl;
                cliente.Cidade = cidade;
                cliente.Estado = estado;
                cliente.Telefone = telefone;
                

                db.Cliente.Add(cliente);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar adicionar cliente", ex);
            }
        }

        public static List<Cliente> All()
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                List<Cliente> cl = db.Cliente.OrderBy(o => o.NomeCliente).ToList();
                return cl;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na lista de cliente", ex);
            }
        }

        public static void Excluir(int cod)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                Cliente c = db.Cliente.SingleOrDefault(obj => obj.idCliente == cod);
                db.Cliente.Remove(c);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao excluir", ex);
            }
        }

        public static void Alterar(int id, string nome, string tipo, string cpf, string rg, string dtnasc, string sexo, string email, string rua, string bairro, string numero, string compl, string cidade, string estado, string telefone)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();                
                Cliente c = db.Cliente.SingleOrDefault(obj => obj.idCliente == id);                
                c.NomeCliente = nome;
                c.TipoCliente = tipo;
                c.CPF = cpf;
                c.RG = rg;
                c.DataNascimento = dtnasc;
                c.Sexo = sexo;
                c.Email = email;
                c.Rua = rua;
                c.Bairro = bairro;
                c.Complemento = compl;
                c.Numero = numero;
                c.Cidade = cidade;
                c.Estado = estado;
                c.Telefone = telefone;

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar cliente", ex);
            }
        }
        public static Cliente LocalizarCliente(int codigoCliente)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                Cliente cliente = db.Cliente.SingleOrDefault(obj => obj.idCliente == codigoCliente); 
                return cliente;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar localizar cliente", ex);
            }
        }
    }
}
