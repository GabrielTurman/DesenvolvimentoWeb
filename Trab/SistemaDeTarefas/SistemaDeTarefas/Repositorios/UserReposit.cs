using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interface;

namespace SistemaDeTarefas.Repositorios
{
    public class UserReposit : iUserRepositorio
    {
        private readonly TarefasSistemaDBContext _dbContext;
        public UserReposit(TarefasSistemaDBContext TarefasSistemaDBContext) 
        {
            _dbContext = TarefasSistemaDBContext;
        }
        public async Task<UsuarioModel> BuscarPorID(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorID(id);
            if(usuarioPorId == null)
            {
                throw new Exception($"Usuario para o id {id} em questão não foi encontrado no banco de dados");
            }

            usuarioPorId.Name = usuario.Name;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;

        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorID(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o id {id} em questão não foi encontrado no banco de dados");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;

        }



    }
}
