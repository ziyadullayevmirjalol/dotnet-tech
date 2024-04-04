namespace Interview.Algorthms;

public class Searching
{
    public int binarySearch(int[] arr, int target, int left, int right)
    {
        var middle = left + (right - left) / 2;
        if (left > right)
            return -1;

        if (arr[middle] == target)
            return middle;

        else if (arr[middle] > target)
            return binarySearch(arr, target, left, middle - 1);
        else
            return binarySearch(arr, target, middle + 1, right);
    }
    public int linearSerach(int[] arr, int target)
    {
        int indexOfTarget = -1;
        if (arr[0] == target)
            return 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                indexOfTarget = i;
                break;
            }
        }
        return indexOfTarget;
    }
}
