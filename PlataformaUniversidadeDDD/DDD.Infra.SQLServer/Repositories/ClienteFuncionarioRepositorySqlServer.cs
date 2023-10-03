using DDD.Domain.ContabilidadeContext;
using DDD.Infra.SQLServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class ClienteFuncionarioRepositorySqlServer : IClienteFuncionarioRepository
    {
        private readonly SqlContext _context;

        public ClienteFuncionarioRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }


        public void DeleteClienteFuncionario(ClienteFuncionario clienteFuncionario)
        {
            throw new NotImplementedException();
        }

        public ClienteFuncionario GetClienteFuncionarioById(int id)
        {
            return _context.ClienteFuncionario.Find(id);
        }

        public List<ClienteFuncionario> GetClienteFuncionario()
        {
            return _context.ClienteFuncionario.ToList();
        }

        public ClienteFuncionario InsertClienteFuncionario(int ClienteId, int FuncionarioId)
        {
            var cliente = _context.Cliente .First(i => i.ClienteId == ClienteId);
            var funcionario = _context.Funcionario.First(i => i.UserId == FuncionarioId);

            var ClienteFuncionario = new ClienteFuncionario
            {
                ClienteId = cliente,
                FuncionarioId = funcionario
            };

            try
            {

                _context.Add(ClienteFuncionario);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                var msg = ex.InnerException;
                throw;
            }

            return ClienteFuncionario;
        }

        public void UpdateClienteFuncionario(ClienteFuncionario clienteFuncionario)
        {
            throw new NotImplementedException();
            throw new NotImplementedException();
        }
    }
}