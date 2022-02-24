namespace MASA.Contrib.DDD.Domain.Repository.EF.Tests.Domain.Entities;

public class Orders : AuditAggregateRoot<int, Guid>
{
    public int OrderNumber { get; set; }

    public DateTime OrderDate { get; private set; }

    public string OrderStatus { get; private set; }

    public string Description { get; set; } = default!;

    public List<OrderItem> OrderItems { get; set; }

    public Orders()
    {
        this.OrderDate = DateTime.UtcNow;
        this.OrderItems = new();
        this.OrderStatus = "Submitted";
    }

    public Orders(int id) : this()
    {
        base.Id = id;
    }

    /// <summary>
    /// Joint primary key, when this method does not exist, the primary key is Id
    /// </summary>
    /// <returns></returns>
    public override IEnumerable<(string Name, object Value)> GetKeys()
    {
        return new List<(string Name, object value)>
        {
            ("Id", Id),
            ("OrderNumber", OrderNumber)
        };
    }
}

