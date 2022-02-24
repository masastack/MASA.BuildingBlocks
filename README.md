[中](README.zh-CN.md) | EN

[![codecov](https://codecov.io/gh/masastack/MASA.Contrib/branch/develop/graph/badge.svg?token=87TPNHUHW2)](https://codecov.io/gh/masastack/MASA.Contrib)

# MASA.Contrib

The purpose of MASA.Contrib is based on [MASA.BuildingBlocks](https://github.com/masastack/MASA.BuildingBlocks) to provide open, community driven reusable components for building mesh applications.  These components will be used by the [MASA Stack](https://github.com/masastack) and [MASA Labs](https://github.com/masalabs) projects.

## Structure

```c#
MASA.Contrib
├── solution items
│   ├── nuget.config
├── src
│   ├── BasicAbility
│   │   ├── MASA.Contrib.BasicAbility.Dcc                          ConfigurationAPI
│   ├── Configuration
│   │   ├── MASA.Contrib.Configuration
│   ├── Data
│   │   ├── MASA.Contrib.Data.UoW.EF                               Unit of work
│   │   └── MASA.Contrib.Data.Contracts.EF                        Protocol EF version
│   ├── DDD
│   │   ├── MASA.Contrib.DDD.Domain                               In-process and cross-process support
│   │   └── MASA.Contrib.DDD.Domain.Repository.EF
│   ├── Dispatcher
│   │   ├── MASA.Contrib.Dispatcher.Events                         In-process event
│   │   ├── MASA.Contrib.Dispatcher.IntegrationEvents.Dapr
│   │   └── MASA.Contrib.Dispatcher.IntegrationEvents.EventLogs.EF Cross-process event
│   ├── ReadWriteSpliting
│   │   └── CQRS
│   │   │   └── MASA.Contrib.ReadWriteSpliting.CQRS                CQRS
│   ├── Service
│   │   └── MASA.Contrib.Service.MinimalAPIs                       Best practices for [MinimalAPI]
├── test
│   ├── MASA.Contrib.Dispatcher.Events
│   │   ├── MASA.Contrib.Dispatcher.Events.BenchmarkDotnetTest
│   │   ├── MASA.Contrib.Dispatcher.Events.CheckMethodsParameter.Tests
│   │   ├── MASA.Contrib.Dispatcher.Events.CheckMethodsParameterNotNull.Tests
│   │   ├── MASA.Contrib.Dispatcher.Events.CheckMethodsParameterType.Tests
│   │   ├── MASA.Contrib.Dispatcher.Events.CheckMethodsType.Tests
│   │   ├── MASA.Contrib.Dispatcher.Events.OnlyCancelHandler.Tests
│   │   ├── MASA.Contrib.Dispatcher.Events.CheckMethodsType.Tests
│   │   ├── MASA.Contrib.Dispatcher.Events.Tests
│   ├── MASA.Contrib.Data.UoW.EF.Tests
│   ├── MASA.Contrib.Dispatcher.IntegrationEvents.EventLogs.EF.Tests
│   ├── MASA.Contrib.DDD.Domain.Tests
│   ├── MASA.Contrib.DDD.Domain.Repository.EF.Tests
```

## Feature

### 1. MinimalAPI

What is [MinimalAPI](https://devblogs.microsoft.com/aspnet/asp-net-core-updates-in-net-6-preview-4/#introducing-minimal-apis)？[Usage introduction](/src/Service/MASA.Contrib.Service.MinimalAPIs/README.md)

>  Advantage：
>
>  1.  Classify APIs and add them to different Services to make the Service structure clearer and get rid of running account programming

### 2. EventBus

[Usage introduction](/src/Dispatcher/MASA.Contrib.Dispatcher.Events/README.md)

> Advantage：
>
> 1. Arrangement of Handler
> 2. Implement [Saga](https://docs.microsoft.com/zh-cn/azure/architecture/reference-architectures/saga/saga)
> 3. Middleware
> 4. Transaction

> Effect：
>
> 1. Event and Handler decoupling
> 2. Arrangement of Handler
> 3. Implement [Saga](https://docs.microsoft.com/zh-cn/azure/architecture/reference-architectures/saga/saga)
> 4. Middleware
> 5. Transaction

### 3. CQRS

what is[CQRS](https://docs.microsoft.com/en-us/azure/architecture/patterns/cqrs)？[Usage introduction](/src/ReadWriteSpliting/CQRS/MASA.Contrib.ReadWriteSpliting.CQRS/README.md)

### 4. IntegrationEventBus

Realize cross-process events based on Dapr。[Usage introduction](/src/Dispatcher/MASA.Contrib.Dispatcher.IntegrationEvents.Dapr/README.md)

> Advantage：Use the same transaction to commit the user-defined context and the log to ensure atomicity and consistency

### 5. DomainEventBus

[Usage introduction](/src/DDD/MASA.Contrib.DDD.Domain/README.md)

> Advantage：
>
> 1. CQRS
> 2. Domain Service
> 3. Support domain events (in-process), integrated domain events (cross-process)
> 4. Support the unified sending of field events after being pushed onto the stack

### 6. DDD

[DDD](https://www.likecs.com/default/index/show?id=93970) // todo


### 7. Contracts.EF

Protocol based on EF implementation，[Usage introduction](/Data/MASA.Contrib.Data.Contracts.EF/README.md)

> Advantage：
>
> 1. Filter deleted information when querying
> 2. Soft delete

```C#
Install-Package MASA.Contrib.Data.Contracts.EF
```

```C#
builder.Services.AddEventBus(options => {
    options.UseUoW<CustomDbContext>(dbOptions =>
    {
        dbOptions.UseSqlServer("server=localhost;uid=sa;pwd=P@ssw0rd;database=identity");
        dbOptions.UseSoftDelete(builder.Services);
    });
});

```

> When the entity inherits ISoftware and is deleted, change the delete state to the modified state, and cooperate with the custom Remove operation to achieve soft deletion
> Do not query the data marked as soft deleted when querying
> When combined with EventBus, the transaction is opened after the first CUD, and the transaction rollback is supported when the entire Handler is abnormal.

### 8. MASA.Contrib.Configuration

Redefine Configuration, support the management of Local and ConfigurationAPI nodes, combine IOptions and IOptionsMonitor to complete configuration acquisition and configuration update subscription [Local Usage introduction](src/Configuration/MASA.Contrib.Configuration/README.md) 、[Dcc Usage introduction](src/BasicAbility/MASA.Contrib.BasicAbility.Dcc/README.md)

## Unit testing rules

To ensure the reliability of the entire source code, the unit test coverage is at least 90%

## ☀️ License agreement

[![MASA.Contrib](https://img.shields.io/badge/License-MIT-blue?style=flat-square)](/LICENSE.txt)
