
namespace Masa.BuildingBlocks.BasicAbility.Pm
{
    public interface IPmClient
    {
        public IEnvironmentService EnvironmentService { get; init; }

        public IClusterService ClusterService { get; init; }

        public IProjectService ProjectService { get; init; }

        public IAppService AppService { get; init; }
    }
}
