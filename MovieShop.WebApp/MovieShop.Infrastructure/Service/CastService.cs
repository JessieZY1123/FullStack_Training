using MovieShop.ApplicationCore.Contracts.Repository;
using MovieShop.ApplicationCore.Contracts.Services;
using MovieShop.ApplicationCore.Model;

namespace MovieShop.Infrastructure.Service
{
    public class CastService : ICastService
    {
        ICastRepository _castRepository;
        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;   
        }
        public async Task<CastModel> GetCastDetail(int id)
        {
            var CastDetails = await _castRepository.GetById(id);
            
            var castModel = new CastModel
            {
                Id = CastDetails.Id,
                Name = CastDetails.Name,
                Gender = CastDetails.Gender,
                ProfilePath = CastDetails.ProfilePath
            };
            return castModel;
        }
    }
}
