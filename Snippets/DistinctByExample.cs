namespace Fiddle.Snippets;

public class PersonDTO
{
    public PersonDTO() { }

    public PersonDTO(int id, string name, string registerId)
    {
        Id = id;
        Name = name;
        RegisterId = registerId;
    }

    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string RegisterId { get; set; } = new Guid().ToString();
}

public class DistinctByExample
{
    Random random;
    List<PersonDTO> people;

    public DistinctByExample(int peopleListCount) {
        random = new Random();
        people = new List<PersonDTO>();
        string[] FirstNameList = {"Luan", "George", "Lucas", "Allaphy", "John"};
        string[] LastNameList = { "Santos", "Santana", "Gois", "Barbosa", "Teles", "Fernandes", "Hora" };



        for (var i = 0; i < peopleListCount; i++)
        {
            var person = new PersonDTO
            (
                id: i + 1,
                name: FirstNameList[random.Next(FirstNameList.Length)] + ' ' + LastNameList[random.Next(LastNameList.Length)],
                registerId: Guid.NewGuid().ToString()
            );

            // Duplicate person list
            people.Add(person);
            people.Add(person);
        }

        var countDistinct = people.AsEnumerable().DistinctBy(x => x.RegisterId).Count();

        Console.WriteLine("========================");
        Console.WriteLine($"Person List with duplicates: {people.Count()}");
        Console.WriteLine("========================");
        Console.WriteLine($"Person List without duplicates: {countDistinct}");
        Console.WriteLine("========================");
    }
}
