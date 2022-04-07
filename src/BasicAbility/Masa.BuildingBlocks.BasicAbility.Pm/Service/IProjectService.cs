namespace Masa.BuildingBlocks.BasicAbility.Pm.Service
{
    public interface IProjectService
    {
        Task<List<ProjectModel>> GetProjectListAsync(string envName);
    }
}
