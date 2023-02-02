using pattern_matching.Classes;

public class PatternMatchingExamples : IPatternMatchingExamples
{
    // Determine whether an expression is equal to a specified constant
    public string ConstantPattern(Person example)
    {
        int number = 0;
        if (number is 0)
        {

            return $"{nameof(example)} equals 0";
        }

        var result = 0 switch
        {
            0 => "ZERO",
            1 => "ONE",
            2 => "TWO"
        };


        // Most used example
        if (example is null) { }

        return string.Empty;
    }

    //  Determine at run-time whether an expression has been certain type
    public string DeclarationPattern(Person example)
    {
        if (example is Person newVar)
        {
        }

        object newPerson = new Person { Name = "Ren", Age = 12 };
        if (newPerson is Person person)
        {
            return "Match";
        }

        return string.Empty;
    }

    //  Discard pattern
    public string DiscardPattern(Person example)
    {
        _ = example ?? throw new ArgumentException();

        var result = 0 switch
        {
            _ => "Default"
        };

        return result;
    }

    // Property pattern
    public string PropertyPattern(Person example)
    {
        var result = example switch
        {
            { Name: "Ren" } => "Ren",
            { Name: "Stimpy" } => "Stimpy"
        };

        if (example is Person { Name: "Ren", Age: 12 } twelveYearRen)
        {
            return $"Hi {twelveYearRen.Name}";
        }

        return result;
    }

    // Var pattern
    public string VarPattern()
    {
        var text = string.Empty;
        var stringArray = new string[] { "1", "2", "3" };

        stringArray.Where(list => list.Count() is var count && count <= 1);

        switch (text)
        {
            case var example when (stringArray).Contains(text):
                return example;
        }

        return string.Empty;
    }

    // De constructing properties from
    public string PositionalPattern(Person example)
    {
        (string name, int age, Location? location) = example;

        return $"{name} - {age}";
    }

    // Pattern match on multiple input values
    public string TuplePattern(Person example)
    {
        var message = (example.Name, example.Age) switch
        {
            ("Ren", 10) => "Hi 10 year old Ren!",
            ("Stimpy", 20) => "Hi 20 year old Stimpy",
        };

        return string.Empty;
    }

    // Allows you to use relation operators (=, >, <, >=, <=) to test pattern
    public string RelationalPattern(Person ren)
    {
        if (ren.Age is > 10)
        {
            return $"Hi Ren!";
        }

        var result = 5 switch
        {
            > 5 => "Greater than 5",
            < 5 => "less than 5",
            <= 5 => "less than or equal to 5",
        };

        return string.Empty;
    }

    //  Determine at run-time whether an expression is of a certain type,
    public string TypePattern(object example)
    {
        if (example is Person)
        {
            return $"{example} is a persons object";
        }

        return string.Empty;
    }

    public string LogicalPatterns(object example)
    {
        if (example is Person { Age: >= 12 and <= 20 })
        {
            return $"Teenager!";
        }

        if (example is Person { Age: 10 or 20 })
        {
            return $"Hello 10 or 20 year old!";
        }

        return string.Empty;
    }
    public string ExtendedPropertyPatterns(Person person)
    {
        var result = person switch
        {
            { Location.Name: "London" } => "London",
            _ => throw new NotImplementedException()
        };

        return string.Empty;
    }
}
