namespace MASA.BuildingBlocks.DDD.Domain.Tests;
[TestClass]
public class TestEntity
{
    [TestMethod]
    public void TestToString()
    {
        MasaEntity entity = new() { Id = Guid.Empty };
        Assert.AreEqual("MasaEntity:Id=00000000-0000-0000-0000-000000000000", entity.ToString());
    }

    [TestMethod]
    public void TestEquals()
    {
        var id = Guid.NewGuid();
        MasaEntity x = new() { Id = id };
        MasaEntity y = new() { Id = id };

        Assert.IsTrue(x.Equals(y));
        Assert.IsTrue(x.Equals((object)y));
    }

    [TestMethod]
    public void TestGetHashCode()
    {
        var id = Guid.NewGuid();
        MasaEntity x = new() { Id = id };
        MasaEntity y = new() { Id = id };

        Assert.AreEqual(x.GetHashCode(), y.GetHashCode());
    }

    [TestMethod]
    public void TestOperator()
    {
        var id = Guid.NewGuid();
        MasaEntity x = new() { Id = id };
        MasaEntity y = new() { Id = id };
        MasaEntity z = new() { Id = Guid.NewGuid() };

        Assert.IsTrue(x == y);
        Assert.IsTrue(x != z);
    }

    public class MasaEntity : Entity<Guid>
    {

    }
}