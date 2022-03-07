namespace Masa.BuildingBlocks.Data.UoW;
public enum CommitState
{
    /// <summary>
    /// A transaction is opened and the data has changed
    /// </summary>
    UnCommited,
    /// <summary>
    /// The transaction is not opened or the data has not changed
    /// </summary>
    Commited
}
