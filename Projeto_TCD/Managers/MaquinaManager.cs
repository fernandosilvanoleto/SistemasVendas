using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCD.Managers
{ 
    public class MaquinaManager
    { 
        public static void Adicionar(int codM, string nome, string modelo, int ano, string motor, string potencia, 
            string combustivel, int peso, string cor, double valor)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                Maquina maq = new Maquina();

                maq.idMarca = codM;
                maq.Nome = nome;
                maq.Modelo = modelo;
                maq.AnoFabricacao = ano;
                maq.Motor = motor;
                maq.Potencia = potencia;
                maq.Combustivel = combustivel;
                maq.PesoMaquina = peso;
                maq.Cor = cor;
                maq.ValorMaquina = (decimal)valor;
                maq.Status = "Disponvível";
               

                db.Maquina.Add(maq);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar adicionar Máquina", ex);
            }
        }

        public static List<Maquina> All()
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                List<Maquina> mq = db.Maquina.OrderBy(o => o.Nome).ToList();
                return mq;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar listar todos a máquina", ex);
            }
        }

        public static void Excluir(int cod)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                Maquina maqui = db.Maquina.SingleOrDefault(obj => obj.idMaquina == cod);

               
                db.Maquina.Remove(maqui);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Excluir!", ex);
            }
        }

        public static void Alterar(int id, int codM, string nome, string modelo, int ano, string motor, string potencia,
            string combustivel, int peso, string cor, double valor)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                Maquina maq = db.Maquina.SingleOrDefault(o => o.idMaquina == id);
                maq.idMarca = codM;
                maq.Nome = nome;
                maq.Modelo = modelo;
                maq.AnoFabricacao = ano;
                maq.Motor = motor;
                maq.Potencia = potencia;
                maq.Combustivel = combustivel;
                maq.PesoMaquina = peso;
                maq.Cor = cor;
                maq.ValorMaquina = (decimal)valor;
                

                db.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar cliente", ex);
            }
        }
        public static void StatusMaquina(int codMaquina, string transfere)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();

                Maquina maq = db.Maquina.SingleOrDefault(o => o.idMaquina == codMaquina);

                maq.Status = transfere;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar transferir no banco", ex);
            }
        }
        public static Maquina Maquina(int cod)
        {
            try
            {
                DatabaseBancosEntities1 db = new DatabaseBancosEntities1();
                db.Database.Connection.Open();
                Maquina maqui = db.Maquina.SingleOrDefault(obj => obj.idMaquina == cod);
                return maqui;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar localizar máquina", ex);
            }
        }
    }
}
