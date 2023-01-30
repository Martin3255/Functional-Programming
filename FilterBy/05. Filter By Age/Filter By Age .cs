using _05._Filter_By_Age;

int n = int.Parse(Console.ReadLine());

List<string> people = new List<string>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");

    people.Add(new Person() { Name = input[0], Age = int.Parse(input[1]) });
}