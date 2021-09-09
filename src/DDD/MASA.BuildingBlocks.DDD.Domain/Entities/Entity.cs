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

        public override bool Equals(object? obj)
        {
            if (this is null ^ obj is null) return false;

            if (obj is Entity entity)
            {
                return entity.GetKeys().Select(key => key.Value).SequenceEqual(GetKeys().Select(key => key.Value));
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return GetKeys().Select(key => key.Value).Aggregate(0, (hashCode, next) => HashCode.Combine(hashCode, next));
        }

        public static bool operator ==(Entity x, Entity y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(Entity x, Entity y)
        {
            return !x.Equals(y);
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
