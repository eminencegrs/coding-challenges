public static void Main(string[l args)
{
    var arr = new int[] { 10, 40, 200, 1000, 60, 30 };
	if (arr.Length < 2) return;

	var p1 = 1;
	var p2 = arr.Length - 2;
	var res = new int] { 1, 1, 1, 1, 1, 1 };
	while (p1 < arr.Length & p2 >= 0)
	{
		if (arr[p1] > arr[p1 - 1])
			res[p1] = res[p1-1]+1;

		if (arr[p2] > arr[p2 + 1])
			res[p2] = res[p2+1]+1;

		p1++;
        p2--;
	}

	// Output: 1, 2, 3, 4, 2, 1
	Console.WriteLine(string.Join(", ", res));
}