namespace MASA.BuildingBlocks.DDD.Domain.Entities
{
    public abstract class Entity : IEntity
    {
        public abstract IEnumerable<(string Name, object Value)> GetKeys();

        /// <inheritdoc/>
        public override string ToString()
        {
            var keys = GetKeys().ToArray();
            string connector = keys.Length > 1 ? Environment.NewLine : string.Empty;

            return $"{GetType().Name}:{connector}{string.Join(Environment.NewLine, keys.Select(key => $"{key.Name}={key.Value}"))}";
        }
    }

    public class Entity<TKey> : Entity, IEntity<TKey>
    {
        public TKey Id { get; set; } = default!;

        public override IEnumerable<(string Name, object Value)> GetKeys()
        {
            yield return ("Id", Id!);
        }
    }
}
