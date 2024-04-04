namespace Interview.Algorthms;

public class Sorting
{
    public int[] bubbleSort(int[] arr)
    {
        int length = arr.Length;
        while (length != 0)
        {
            int maxindex = 0;
            for (int i = 1; i < length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;

                    maxindex = i;
                }
            }
            length = maxindex;
        }
        return arr;
    }

    public int[] selectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minindex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[minindex] > arr[j])
                {
                    minindex = j;
                }
            }
            if (minindex != i)
            {
                int temp = arr[minindex];
                arr[minindex] = arr[i];
                arr[i] = temp;
            }
        }
        return arr;
    }
    
    public int[] insertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int sorted = i - 1;
            while (sorted > -1 && arr[sorted] > arr[sorted + 1])
            {
                int temp = arr[sorted];
                arr[sorted] = arr[sorted + 1];
                arr[sorted + 1] = temp;
                sorted--;
            }
        }
        return arr;
    }
}