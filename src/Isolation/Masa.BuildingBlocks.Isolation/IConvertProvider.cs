namespace Masa.BuildingBlocks.Isolation;
public interface IConvertProvider
{
    object ChangeType(string value, Type conversionType);
}
