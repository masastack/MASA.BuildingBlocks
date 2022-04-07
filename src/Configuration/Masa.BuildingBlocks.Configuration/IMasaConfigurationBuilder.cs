namespace Masa.BuildingBlocks.Configuration;
public interface IMasaConfigurationBuilder : IConfigurationBuilder
{
    IConfiguration Configuration { get; }

    void AddRepository(IConfigurationRepository configurationRepository);

    void AddRelations(params ConfigurationRelationOptions[] relationOptions);
}
