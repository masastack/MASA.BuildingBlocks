namespace MASA.Contrib.BasicAbility.Dcc.Tests;

[TestClass]
public class DccClientTest
{
    private Mock<IMemoryCacheClient> _client;
    private IServiceCollection _services;
    private IServiceProvider _serviceProvider => _services.BuildServiceProvider();
    private JsonSerializerOptions _jsonSerializerOptions;
    private DccSectionOptions _dccSectionOptions;
    private CustomTrigger _trigger;

    [TestInitialize]
    public void Initialize()
    {
        _client = new Mock<IMemoryCacheClient>();
        _services = new ServiceCollection();
        _jsonSerializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        _dccSectionOptions = new DccSectionOptions()
        {
            Environment = "Test",
            Cluster = "Default",
            AppId = "DccTest",
            ConfigObjects = new List<string>()
            {
                "Test1"
            },
            Secret = ""
        };
        _trigger = new CustomTrigger(_jsonSerializerOptions);
    }

    [DataTestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task TestGetRawAsync(string environment, string cluster, string appId, string configObject)
    {
        Action<string?> valueChanged = delegate (string? val) { };
        _client.Setup(client => client.GetAsync<string?>(It.IsAny<string>(), valueChanged).Result).Returns(() => null).Verifiable();
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        await Assert.ThrowsExceptionAsync<ArgumentException>(async ()
                => await client.GetRawAsync(environment, cluster, appId, configObject, valueChanged), "configObject invalid"
        );

        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => "test").Verifiable();
        client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        await Assert.ThrowsExceptionAsync<JsonException>(async ()
            => await client.GetRawAsync(environment, cluster, appId, configObject, It.IsAny<Action<string>>())
        );

        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => "{}").Verifiable();
        await Assert.ThrowsExceptionAsync<ArgumentException>(async ()
                => await client.GetRawAsync(environment, cluster, appId, configObject, It.IsAny<Action<string>>()), "configObject invalid"
        );

        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new
        {
            ConfigFormat = "1",
            Content = ""
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        await Assert.ThrowsExceptionAsync<JsonException>(async ()
                => await client.GetRawAsync(environment, cluster, appId, configObject, It.IsAny<Action<string>>()), "configObject invalid"
        );

        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease
        {
            ConfigFormat = (ConfigFormats)5,
            Content = ""
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        await Assert.ThrowsExceptionAsync<NotSupportedException>(
            async () => await client.GetRawAsync(environment, cluster, appId, configObject, It.IsAny<Action<string>>()),
            "Unsupported configuration type");
    }

    [DataTestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task TestGetRawAsyncByJson(string environment, string cluster, string appId, string configObject)
    {
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);

        var brand = new Brands("Apple");
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Json,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        var ret = await client.GetRawAsync(environment, cluster, appId, configObject, It.IsAny<Action<string>>());
        Assert.IsTrue(ret.Raw == brand.Serialize(_jsonSerializerOptions));
        Assert.IsTrue(ret.ConfigurationType == ConfigurationTypes.Json);
    }

    [DataTestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task TestGetRawAsyncByText(string environment, string cluster, string appId, string configObject)
    {
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Text,
            Content = "test"
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        var ret = await client.GetRawAsync(environment, cluster, appId, configObject, It.IsAny<Action<string>>());
        Assert.IsTrue(ret.Raw == "test");
        Assert.IsTrue(ret.ConfigurationType == ConfigurationTypes.Text);
    }

    [DataTestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task TestGetRawAsyncByProperty(string environment, string cluster, string appId, string configObject)
    {
        List<Property> properties = new List<Property>()
        {
            new()
            {
                Key = "Brand",
                Value = "Microsoft"
            }
        };
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Text,
            Content = properties.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        var ret = await client.GetRawAsync(environment, cluster, appId, configObject, It.IsAny<Action<string>>());
        Assert.IsTrue(ret.Raw == properties.Serialize(_jsonSerializerOptions));
        Assert.IsTrue(ret.ConfigurationType == ConfigurationTypes.Text);
    }

    [TestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task GetAsyncByJson(string environment, string cluster, string appId, string configObject)
    {
        var brand = new Brands("Microsoft");
        var newBrand = new Brands("Microsoft2");

        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Json,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Callback((string str, Action<string> action) =>
        {
            _trigger.Formats = ConfigFormats.Json;
            _trigger.Content = newBrand.Serialize(_jsonSerializerOptions);
            _trigger.Action = action;
        });
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        var ret = await client.GetAsync(environment, cluster, appId, configObject, (Brands br) =>
        {
            Assert.IsTrue(br.Id == newBrand.Id);
            Assert.IsTrue(br.Name == newBrand.Name);
        });
        Assert.IsNotNull(ret);

        Assert.IsTrue(ret.Serialize(_jsonSerializerOptions).Equals(brand.Serialize(_jsonSerializerOptions)));
        _trigger.Execute();

        ret = await client.GetAsync(environment, cluster, appId, configObject, It.IsAny<Action<Brands>>());
        Assert.IsNotNull(ret);

        Assert.IsTrue(ret.Id == newBrand.Id && ret.Name == newBrand.Name);

        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Json,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Callback((string str, Action<string> action) =>
        {
            _trigger.Formats = ConfigFormats.Json;
            newBrand.Name = "Masa";
            _trigger.Content = newBrand.Serialize(_jsonSerializerOptions);
            _trigger.Action = action;
        });
        client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        ret = await client.GetAsync<Brands>(environment, cluster, appId, configObject, It.IsAny<Action<Brands>>());
        Assert.IsNotNull(ret);
        Assert.IsTrue(ret.Id == brand.Id && ret.Name == brand.Name);
        _trigger.Execute();
        ret = await client.GetAsync<Brands>(environment, cluster, appId, configObject, It.IsAny<Action<Brands>>());
        Assert.IsTrue(ret.Id == newBrand.Id && ret.Name == "Masa");

        _client.Setup(client => client.GetAsync<string>(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Json,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions));
        client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        ret = await client.GetAsync(environment, cluster, appId, configObject, It.IsAny<Action<Brands>>());
        Assert.IsNotNull(ret);
        Assert.IsTrue(ret.Id == brand.Id && ret.Name == brand.Name);

        Initialize();
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Json,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        await Assert.ThrowsExceptionAsync<FormatException>(async () =>
        {
            await client.GetAsync<int>(environment, cluster, appId, configObject, It.IsAny<Action<int>>());
        });
    }

    [TestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task GetAsyncByText(string environment, string cluster, string appId, string configObject)
    {
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Text,
            Content = "test"
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        await Assert.ThrowsExceptionAsync<JsonException>(async () =>
        {
            await client.GetAsync(environment, cluster, appId, configObject, It.IsAny<Action<Brands>>());
        });

        Initialize();
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Text,
            Content = "1"
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        Assert.IsTrue(await client.GetAsync(environment, cluster, appId, configObject, It.IsAny<Action<int>>()) == 1);
    }

    [TestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task GetAsyncByProperty(string environment, string cluster, string appId, string configObject)
    {
        var brand = new List<Property>()
        {
            new()
            {
                Key = "Id",
                Value = Guid.NewGuid().ToString(),
            },
            new()
            {
                Key = "Name",
                Value = "Microsoft"
            }
        };
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Properties,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        var ret = await client.GetAsync(environment, cluster, appId, configObject, It.IsAny<Action<Brands>>());
        Assert.IsNotNull(ret);

        Assert.IsTrue(ret.Id.ToString() == brand.Where(b => b.Key == "Id").Select(t => t.Value).FirstOrDefault() &&
                      ret.Name == brand.Where(b => b.Key == "Name").Select(t => t.Value).FirstOrDefault());
    }

    [TestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task GetDynamicAsyncByJson(string environment, string cluster, string appId, string configObject)
    {
        var brand = new Brands("Microsoft");
        var newBrand = new Brands("Microsoft2");
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Json,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Callback((string str, Action<string> action) =>
        {
            _trigger.Formats = ConfigFormats.Json;
            _trigger.Content = newBrand.Serialize(_jsonSerializerOptions);
            _trigger.Action = action;
        }).Verifiable();
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        var ret = await client.GetDynamicAsync(environment, cluster, appId, configObject, (dynamic obj) =>
        {
            Assert.IsTrue((obj.Id + "") == newBrand.Id.ToString());

            Assert.IsTrue(obj.Name == newBrand.Name);
        });
        Assert.IsNotNull(ret);

        Assert.IsTrue(ret.Id == brand.Id.ToString());

        Assert.IsTrue(ret.Name == brand.Name);

        _trigger.Execute();

        ret = await client.GetDynamicAsync(environment, cluster, appId, configObject, It.IsAny<Action<dynamic>>());
        Assert.IsNotNull(ret);
        Assert.IsTrue(ret.Id == newBrand.Id.ToString() && ret.Name == newBrand.Name);

        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Json,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Callback((string str, Action<string> action) =>
        {
            _trigger.Formats = ConfigFormats.Json;
            _trigger.Content = newBrand.Serialize(_jsonSerializerOptions);
            _trigger.Action = action;
        }).Verifiable();
        client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        ret = await client.GetDynamicAsync(environment, cluster, appId, configObject, It.IsAny<dynamic>());
        Assert.IsNotNull(ret);
        Assert.IsTrue(ret.Id == brand.Id.ToString());
        Assert.IsTrue(ret.Name == brand.Name);
        _trigger.Execute();

        ret = await client.GetDynamicAsync(environment, cluster, appId, configObject, It.IsAny<Action<dynamic>>());
        Assert.IsNotNull(ret);
        Assert.IsTrue(ret.Id == newBrand.Id.ToString() && ret.Name == newBrand.Name);

        _client.Setup(client => client.GetAsync<string>(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Json,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions));
        client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        ret = await client.GetDynamicAsync(environment, cluster, appId, configObject, It.IsAny<Action<dynamic>>());
        Assert.IsNotNull(ret);
        Assert.IsTrue(ret.Id == brand.Id.ToString() && ret.Name == brand.Name);
    }

    [TestMethod]
    [DataRow("DccOptions.ManageServiceAddress", "http://localhost:6379")]
    [DataRow("DccOptions.RedisOptions.DefaultDatabase", "0")]
    [DataRow("DccOptions.RedisOptions.Password", "")]
    public async Task GetDynamicAsync(string key, string value)
    {
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        _services.AddSingleton<IConfiguration>(configuration);
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        var res = (await client.GetDynamicAsync(key));
        Assert.IsTrue(res + "" == value);
    }

    [TestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task GetDynamicAsyncByText(string environment, string cluster, string appId, string configObject)
    {
        string result = "Test";
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Text,
            Content = result
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        await Assert.ThrowsExceptionAsync<JsonException>(async () =>
        {
            await client.GetDynamicAsync(environment, cluster, appId, configObject, It.IsAny<Action<dynamic>>());
        });
    }

    [TestMethod]
    [DataRow("Test", "Default", "DccTest", "Brand")]
    public async Task GetDynamicAsyncByProperty(string environment, string cluster, string appId, string configObject)
    {
        var brand = new List<Property>()
        {
            new()
            {
                Key = "Id",
                Value = Guid.NewGuid().ToString(),
            },
            new()
            {
                Key = "Name",
                Value = "Microsoft"
            }
        };
        _client.Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<Action<string?>>()).Result).Returns(() => new PublishRelease()
        {
            ConfigFormat = ConfigFormats.Properties,
            Content = brand.Serialize(_jsonSerializerOptions)
        }.Serialize(_jsonSerializerOptions)).Verifiable();
        var client = new ConfigurationApiClient(_serviceProvider, _client.Object, _jsonSerializerOptions, _dccSectionOptions, null);
        var ret = await client.GetDynamicAsync(environment, cluster, appId, configObject, It.IsAny<Action<dynamic>>());
        Assert.IsNotNull(ret);

        Assert.IsTrue(ret.Id == brand.Where(b => b.Key == "Id").Select(b => b.Value).FirstOrDefault());
        Assert.IsTrue(ret.Name == brand.Where(b => b.Key == "Name").Select(b => b.Value).FirstOrDefault());
    }
}
