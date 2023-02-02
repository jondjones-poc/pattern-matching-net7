using pattern_matching.Classes;

public static partial class EndpointMapper
{
    public static WebApplication RegisterEndpoints(this WebApplication app)
    {
        app.MapEndPoints();

        return app;
    }

    public static WebApplication MapEndPoints(this WebApplication app)
    {
        Person ren = new Person
        {
            Name = "Ren",
            Age = 12,
            Location = new Location("London")
        };

        app.MapGet("/constant/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.ConstantPattern(ren);
        });

        app.MapGet("/declaration/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.DeclarationPattern(ren);
        });

        app.MapGet("/discard/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.DiscardPattern(ren);
        });

        app.MapGet("/property/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.PropertyPattern(ren);
        });

        app.MapGet("/var/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.VarPattern();
        });

        app.MapGet("/positional/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.PositionalPattern(ren);
        });

        app.MapGet("/tuple/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.TuplePattern(ren);
        });

        app.MapGet("/relational/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.RelationalPattern(ren);
        });

        app.MapGet("/type/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.TypePattern(ren);
        });

        app.MapGet("/logical/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.LogicalPatterns(ren);
        });

        app.MapGet("/extended/", (IPatternMatchingExamples patternMatchingExamples) => {
            return patternMatchingExamples.ExtendedPropertyPatterns(ren);
        });

        return app;
    }
}