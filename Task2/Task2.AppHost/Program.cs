var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Task2_ApiService>("apiservice");

builder.AddProject<Projects.Task2_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
