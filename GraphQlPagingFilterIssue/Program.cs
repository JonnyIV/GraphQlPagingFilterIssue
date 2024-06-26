using GraphQlPagingFilterIssue;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .AddGraphQLFunction(b => b
        .AddQueryType<Query>()
        .AddFiltering()
        .AddProjections()
    )
    .Build()
    .Run();
