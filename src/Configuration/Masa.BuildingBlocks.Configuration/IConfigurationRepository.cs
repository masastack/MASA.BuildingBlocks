namespace Masa.BuildingBlocks.Configuration;
public interface IConfigurationRepository
{
    SectionTypes SectionType { get; }

    Properties Load();

    void AddChangeListener(IRepositoryChangeListener listener);

    void RemoveChangeListener(IRepositoryChangeListener listener);
}
