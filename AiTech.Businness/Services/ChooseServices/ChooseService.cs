using AiTech.DataAccess.Repositories.ChooseRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.ChooseDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Businness.Services.ChooseServices
{
    public class ChooseService(IChooseRepository _chooseRepository, IUnitOfWork _unitOfWork) : IChooseService
    {
        public async Task TCreateAsync(CreateChooseDto createdDto)
        {
            var choose = createdDto.Adapt<Choose>();
            await _chooseRepository.CreateAsync(choose);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var choose = await _chooseRepository.GetByIdAsync(id);
            _chooseRepository.Delete(choose);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultChooseDto>> TGetAllAsync()
        {
            var chooses = await _chooseRepository.GetAllAsync();
            return chooses.Adapt<List<ResultChooseDto>>();
        }

        public async Task<ResultChooseDto> TGetByIdAsync(int id)
        {
            var choose = await _chooseRepository.GetByIdAsync(id);
            return choose.Adapt<ResultChooseDto>();
        }

        public Task TUpdateAsync(UpdateChooseDto updateDto)
        {
            var choose = updateDto.Adapt<Choose>();
            _chooseRepository.Update(choose);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
