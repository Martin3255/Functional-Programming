var nums = new List<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToList());

int elCount = nums.Count;

int elSum = 0;

for (int i = 0; i < nums.Count; i++)
{
    elSum += nums[i];
}
Console.WriteLine(elCount);
Console.WriteLine(elSum);