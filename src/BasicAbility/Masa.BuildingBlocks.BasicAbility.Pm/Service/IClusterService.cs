namespace Masa.BuildingBlocks.BasicAbility.Pm.Service
{
    public interface IClusterService
    {
        Task<List<ClusterModel>> GetListAsync();

        Task<List<ClusterModel>> GetListByEnvIdAsync(int envId);

        Task<ClusterDetailModel> GetAsync(int Id);

        Task<List<EnvironmentClusterModel>> GetEnvironmentClustersAsync();
    }
}
