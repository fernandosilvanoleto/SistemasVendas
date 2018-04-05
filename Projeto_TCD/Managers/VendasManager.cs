using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCD.Managers
{
    public class VendasManager
    {
        public static void RealizarVendas(int codCliente, int codGer, int codVend, int codMaq, int codTransportadora, 
            DateTime data, double freteT,double custoTotal, string estCompra,
            string cidadeCompra, int qtProd,string cidDest, string estDest,
            double desconto,string enderecoEnt, Boolean gerente)
        {
            
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                Vendas venda = new Vendas();
                if (gerente)
                {
                    venda.idGerente = codGer;
                }
                venda.idCliente = codCliente;
                venda.idVendedor = codVend;
                venda.idMaquina = codMaq;
                venda.idTransportadora = codTransportadora;

                venda.DataVenda = data;
                venda.FreteTotal = (decimal)freteT;
                
                venda.CustoTotal = (decimal)custoTotal;
                venda.EstadoCompra = estCompra;
                venda.CidadeCompra = cidadeCompra;
                venda.QtProdutos = qtProd;
                venda.EstadoDestino = estDest;
                venda.CidadeDestino = cidDest;
                venda.DescontoVenda = (decimal)desconto;                
                venda.EnderecoEntrega = enderecoEnt;
               
                

                db.Vendas.Add(venda);
                db.SaveChanges();
            }            
            catch (Exception ex)
            {//tratamento de erro na camada inferior
                throw new Exception("Ocorreu um erro ao realizar vendas!", ex);
            }
        }

        public static List<Vendas> All()
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                List<Vendas> vendasAll = db.Vendas.OrderBy(v => v.idVenda).ToList();
                return vendasAll;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar listar máquinas", ex);
            }

        }
        public static void RemoverVenda(int codVenda)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                Vendas v = db.Vendas.SingleOrDefault(o => o.idVenda == codVenda);

                db.Vendas.Remove(v);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar remover vendas", ex);
            }
        }
        public static void Alterar(int codVenda, int codCliente, int codGer, int codVend, int codMaq, int codTransportadora,
            DateTime data, double freteT, double custoTotal, string estCompra,
            string cidadeCompra, int qtProd, string cidDest, string estDest,
            double desconto, string enderecoEnt, Boolean gerente)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                Vendas venda = db.Vendas.SingleOrDefault(o => o.idVenda == codVenda);

                if (gerente)
                {
                    venda.idGerente = codGer;
                }
                venda.idCliente = codCliente;
                venda.idVendedor = codVend;
                venda.idMaquina = codMaq;
                venda.idTransportadora = codTransportadora;
                venda.DataVenda = data;
                venda.FreteTotal = (decimal)freteT;
                venda.CustoTotal = (decimal)custoTotal;
                venda.EstadoCompra = estCompra;
                venda.CidadeCompra = cidadeCompra;
                venda.QtProdutos = qtProd;
                venda.EstadoDestino = estDest;
                venda.CidadeDestino = cidDest;
                venda.DescontoVenda = (decimal)desconto;
                venda.EnderecoEntrega = enderecoEnt;
                

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar vendas", ex);
            }
        }

        public static Vendas Localizar(int cod)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                Vendas venda = db.Vendas.SingleOrDefault(o => o.idVenda == cod);
                return venda;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar localizar vendas", ex);
            }
        }
    }
}
