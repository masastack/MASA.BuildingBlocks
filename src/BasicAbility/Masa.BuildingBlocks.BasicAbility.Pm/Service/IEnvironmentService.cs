namespace Masa.BuildingBlocks.BasicAbility.Pm.Service
{
    public interface IEnvironmentService
    {
        Task<List<EnvironmentModel>> GetListAsync();

        Task<EnvironmentDetailModel> GetAsync(int Id);
    }
}
