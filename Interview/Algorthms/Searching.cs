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
}
