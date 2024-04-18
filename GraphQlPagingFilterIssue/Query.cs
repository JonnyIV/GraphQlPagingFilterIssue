using HotChocolate.Types;

namespace GraphQlPagingFilterIssue;


public class Query
{
    [UseProjection]
    public IQueryable<Movie> GetMovie() => new Movie[] { new() { Name = "Star Wars" } }.AsQueryable();
}

public class Movie
{
    public string Name { get; set; } = "";

    [UseFiltering]
    public IQueryable<Character> GetCharacters()
    {
        return new Character[]
        {
            new() { Name = "Luke Skywalker" },
            new() { Name = "Darth Vader" },
            new() { Name = "Princess Leia" }
        }.AsQueryable();
    }
}


public class Character
{
    public string Name { get; set; } = "";
}