namespace Masa.BuildingBlocks.Configuration;
public interface IMasaConfigurationBuilder : IConfigurationBuilder
{
    IServiceCollection Services { get; }

    IConfiguration Configuration { get; }

    void AddRepository(IConfigurationRepository configurationRepository);

    void AddRelations(params ConfigurationRelationOptions[] relationOptions);
}
