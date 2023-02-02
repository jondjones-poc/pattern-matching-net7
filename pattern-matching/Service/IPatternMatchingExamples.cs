using pattern_matching.Classes;

public interface IPatternMatchingExamples
{
    string ConstantPattern(Person example);

    string DeclarationPattern(Person example);

    string DiscardPattern(Person example);

    string PropertyPattern(Person example);

    string VarPattern();

    string PositionalPattern(Person example);

    string TuplePattern(Person example);

    string RelationalPattern(Person ren);

    string TypePattern(object example);

    string LogicalPatterns(object example);

    string ExtendedPropertyPatterns(Person person);
}