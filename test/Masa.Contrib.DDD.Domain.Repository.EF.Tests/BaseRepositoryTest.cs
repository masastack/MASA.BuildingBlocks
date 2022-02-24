namespace MASA.Contrib.DDD.Domain.Repository.EF.Tests;

[TestClass]
public class BaseRepositoryTest : TestBase
{
    private IServiceCollection _services = default!;
    private Assembly[] _assemblies;
    private Mock<IUnitOfWork> _uoW;
    private Mock<IDispatcherOptions> _dispatcherOptions = default!;

    [TestInitialize]
    public void Initialize()
    {
        _services = new ServiceCollection();
        _assemblies = new Assembly[1]
        {
            typeof(BaseRepositoryTest).Assembly
        };
        _uoW = new();
        _dispatcherOptions = new();
        _dispatcherOptions.Setup(options => options.Services).Returns(() => _services);
    }

    [TestMethod]
    public void TestNullServices()
    {
        Assert.ThrowsException<ArgumentNullException>(() =>
        {
            _dispatcherOptions.Setup(options => options.Services).Returns(() => null!);
            var options = _dispatcherOptions.Object.UseRepository<CustomDbContext>();
        });
    }

    [TestMethod]
    public void TestUseCustomRepositoryAndNotImplementation()
    {
        Mock<IUnitOfWork> uoW = new();
        _services.AddScoped(serviceProvider => uoW.Object);

        Assert.ThrowsException<NotSupportedException>(()
            => _dispatcherOptions.Object.UseRepository<CustomDbContext>(typeof(TestBase).Assembly, typeof(IUserRepository).Assembly)
        );
    }

    [TestMethod]
    public void TestNullUnitOfWork()
    {
        var ex = Assert.ThrowsException<Exception>(() =>
        {
            _dispatcherOptions.Object.UseRepository<CustomDbContext>(_assemblies);
        });
        Assert.IsTrue(ex.Message == "Please add UoW first.");
    }

    [TestMethod]
    public void TestNullAssembly()
    {
        _services.AddScoped(typeof(IUnitOfWork), serviceProvider => _uoW.Object);
        _services.AddDbContext<CustomDbContext>(options => options.UseSqlite(_connection));

        Assert.ThrowsException<ArgumentNullException>(() =>
        {
            _dispatcherOptions.Object.UseRepository<CustomDbContext>(null!);
        });
    }

    [TestMethod]
    public void TestAddMultRepository()
    {
        _services.AddScoped(typeof(IUnitOfWork), serviceProvider => _uoW.Object);
        _services.AddDbContext<CustomDbContext>(options => options.UseSqlite(_connection));
        _dispatcherOptions.Object.UseRepository<CustomDbContext>(_assemblies).UseRepository<CustomDbContext>();

        var serviceProvider = _services.BuildServiceProvider();
        var repository = serviceProvider.GetServices<IRepository<Orders>>();
        Assert.IsTrue(repository.Count() == 1);
    }
}
