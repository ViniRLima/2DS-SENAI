using Senai.Rental.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório EmpresaRepository
    /// </summary>
    interface IEmpresaRepository
    {
        /// <summary>
        /// Listar todas as Empresas
        /// </summary>
        /// <returns>Lista de Empresas</returns>
        List<EmpresaDomain> ListarTodos();

        /// <summary>
        /// Busca uma empresa através do seu id
        /// </summary>
        /// <param name="idEmpresa">id da empresa que será buscada</param>
        /// <returns>Uma empresa buscada</returns>
        EmpresaDomain BuscarPorId(int idEmpresa);

        /// <summary>
        /// Cadastra uma nova Empresa
        /// </summary>
        /// <param name="novaEmpresa">Objeto novaEmpresa com os novos dados</param>
        void Cadastrar(EmpresaDomain novaEmpresa);

        /// <summary>
        /// Atualiza uma empresa existente
        /// </summary>
        /// <param name="empresaAtualizada">Objeto com os novos dados atualizados</param>
        void AtualizarIdCorpo(EmpresaDomain empresaAtualizada);

        /// <summary>
        /// Atualiza uma empresa existente
        /// </summary>
        /// <param name="idEmpresa">id da empresa que será atualizada</param>
        /// <param name="empresaAtualizada">Objeto empresaAtualizada com os novos dados atualizados</param>
        void AtualizarIdUrl(int idEmpresa, EmpresaDomain empresaAtualizada);

        /// <summary>
        /// Deleta uma empresa existente
        /// </summary>
        /// <param name="idEmpresa">id da empresa que será deletada</param>
        void Deletar(int idEmpresa);
    }
}
