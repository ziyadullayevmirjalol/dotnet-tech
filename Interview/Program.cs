using Interview.Algorthms;

Sorting sorting = new Sorting();

foreach (var item in sorting.bubbleSort(new int[] { 10, 200, 30, 41, 52, 63, 7, 8, 93 }))
    Console.WriteLine(item);
foreach (var item in sorting.selectionSort(new int[] { 10, 200, 30, 41, 52, 63, 7, 8, 93 }))
    Console.WriteLine(item);
foreach (var item in sorting.insertionSort(new int[] { 10, 200, 30, 41, 52, 63, 7, 8, 93 }))
    Console.WriteLine(item);