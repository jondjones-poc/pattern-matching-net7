namespace pattern_matching;

public static partial class ServiceInitializer
{
    public static IServiceCollection RegisterApplicationServices(
                    this IServiceCollection services)
    {
        RegisterSwagger(services);
        RegisterCustomDependencies(services);
        return services;
    }

    private static void RegisterCustomDependencies(IServiceCollection services)
    {
        services.AddTransient<IPatternMatchingExamples, PatternMatchingExamples>();
    }

    private static void RegisterSwagger(IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}

