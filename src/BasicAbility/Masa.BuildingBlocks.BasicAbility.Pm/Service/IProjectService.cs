namespace Masa.BuildingBlocks.BasicAbility.Pm.Service
{
    public interface IProjectService
    {
        Task<List<ProjectAppsModel>> GetProjectAppsAsync(string envName);

        Task<List<ProjectModel>> GetListByEnvironmentClusterIdAsync(int envClusterId);

        Task<List<ProjectModel>> GetListByTeamIdAsync(Guid teamId);

        Task<ProjectDetailModel> GetAsync(int Id);

        Task<List<ProjectTypeModel>> GetProjectTypesAsync();
    }
}
