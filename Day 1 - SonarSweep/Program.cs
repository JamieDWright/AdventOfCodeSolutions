
PartOne();
PartTwo();

void PartOne()
{
    var depthIncreases = -1; //dont start at zero to ignore first increase
    var previousDepth = 0;

    foreach (string line in File.ReadLines("input.txt"))
    {
        int.TryParse(line.Trim(), out var depth);
        depthIncreases = depth > previousDepth ? depthIncreases + 1 : depthIncreases;
        previousDepth = depth;
    }

    Console.WriteLine($"Part One: Reading the input file, {depthIncreases} are larger than the previous measurement.");
}

void PartTwo()
{
    var depthIncreases = -1; //dont start at zero to ignore first increase
    var previousTotal = 0;
    var currentTotal = 0;
    var depths = new List<int>();

    foreach (string line in File.ReadLines("input.txt"))
    {
        int.TryParse(line.Trim(), out var depth);
        depths.Add(depth);
    }

    while(depths.Count > 2)
    {
        currentTotal = depths[0] + depths[1] + depths[2];
        depthIncreases = currentTotal > previousTotal ? depthIncreases + 1 : depthIncreases;
        previousTotal = currentTotal;
        depths.RemoveAt(0);
    }

    Console.WriteLine($"Part Two: Reading the input file, {depthIncreases} sums in the sliding window are larger than the previous sum.");
}