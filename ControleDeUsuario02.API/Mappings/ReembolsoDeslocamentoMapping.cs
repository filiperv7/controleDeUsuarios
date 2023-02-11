using AutoMapper;
using ControleDeUsuario02.API.Model.Resource;
using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.API.Mappings {
    public class ReembolsoDeslocamentoMapping : Profile {

        public ReembolsoDeslocamentoMapping() {
            CreateMap<ReembolsoDeslocamento, ReembolsoDeslocamentoResource>().ReverseMap()
                .ForMember(_ => _.DataCriacao, opt => opt.AddTransform(data => DateTime.Now));

            /*CreateMap<List<ReembolsoDeslocamento>, List<ReembolsoDeslocamentoResource>>().ReverseMap();*/
        }
    }
}
