using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Domain.Services.Services
{
    public class VendaService : ServiceBase<VendaEntity>, IVendaService
    {
        private readonly IVendaRepository _repository;

        public VendaService(IVendaRepository repository)
            : base(repository)
        {
            _repository = repository;
        }


        public async Task Autorizar(long id)
        {
            var venda = await _repository.GetById(id);

            if (venda == null)
            {
                throw new Exception("Solicitação de venda não encontrada");
            }

            var ordemServico = venda.OrdemProducao;

            if(ordemServico == null)
            {
                throw new Exception("Erro ao encontrar Ordem de Produção");
            }

            var produto = venda.Produto;


            if (produto == null)
            {
                throw new Exception("Erro ao encontrar produto");
            }

            var produtosProduzidos = ordemServico.Producao;

            var quantidadeProdutosProduzidos = 0;

            foreach( var item  in produtosProduzidos)
            {
                quantidadeProdutosProduzidos += item.Quantidade ?? 0;
            }

            if(quantidadeProdutosProduzidos < venda.Quantidade)
            {
                throw new Exception("Quantidade de produtos insuficiente.");
            }
            else
            {
                venda.Status = 1;
                venda.OrdemProducao.Status = 1; 
                await _repository.Update(venda);
            }
        }
    }
}
