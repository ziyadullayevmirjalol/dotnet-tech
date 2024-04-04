using Interview.Algorthms;

Sorting sorting = new Sorting();

foreach (var item in sorting.bubbleSort(new int[] { 10, 200, 30, 41, 52, 63, 7, 8, 93 }))
    Console.WriteLine(item);
foreach (var item in sorting.selectionSort(new int[] { 10, 200, 30, 41, 52, 63, 7, 8, 93 }))
    Console.WriteLine(item);
foreach (var item in sorting.insertionSort(new int[] { 10, 200, 30, 41, 52, 63, 7, 8, 93, 0 }))
    Console.WriteLine(item);

Searching searching = new Searching();

var sorted = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
var target = 11;

Console.WriteLine($"Index of {target} is :" + searching.binarySearch(sorted, target, 0, 9));