var array = new int[] { 29, 11, 14, 56, 88, 65, 32, 45, 66, 88, 99, 21, 1, 3, 76, 2, 31, 57, 89 };

Console.WriteLine(string.Join(", ", array));

var sortedArray = QuickSort.Quick_Sort(array, 0, array.Length - 1);
Console.WriteLine(string.Join(", ", sortedArray));

var rsrs = 0;
public static class QuickSort
{
    public static int[] Quick_Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                Quick_Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Quick_Sort(arr, pivot + 1, right);
            }
        }

        return arr;

    }


    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {

            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;


            }
            else
            {
                return right;
            }
        }
    }


    /*Quick sort selects a pivot and rearrange the elements putting them on the left if they are less than the pivot, and to the right if they are 
    bigger than the pivot, it will divide in two "imaginary" arrays, one with smaller values and other with bigger values, because of recurssion it 
    will repeat the process to all elements(left and right recursively) until it navigated to the whole array.*/
    // public static int[] QuickSortArray(int[] values, int leftIndex, int rightIndex)
    // {
    //     //Assign values to temporary left and right indexes(they shall change during recurssion)
    //     var lInd = leftIndex;
    //     var rInd = leftIndex;
    //     //In our code, the pivot is always the value more on the left
    //     var pivot = values[leftIndex];

    //     //It will run until left is smaller than right, as it puts smaller values on the left and bigger on the right, this will stops as soon as they touch the pivot
    //     while (lInd < rInd)
    //     {
    //         //while values on the left(left will be "walking" from left->right) are less than the pivot, jump to the next element because those values are ordered until finding on that is bigger or is the pivot
    //         while (values[rInd] >= pivot && lInd < rInd)
    //             rInd--;

    //         if (lInd != rightIndex)
    //         {
    //             values[lInd] = values[rInd];
    //             lInd++;
    //         }

    //         while (values[lInd] <= pivot && lInd < rInd)
    //             lInd++;


    //         if (lInd != rightIndex)
    //         {
    //             values[rightIndex] = values[leftIndex];
    //             rInd--;
    //         }

    //     }

    //     values[lInd] = pivot;
    //     pivot = lInd;
    //     lInd = leftIndex;
    //     rInd = rightIndex;

    //     if (leftIndex < rInd)
    //         QuickSortArray(values, lInd, pivot - 1);

    //     if (lInd < rightIndex)
    //         QuickSortArray(values, pivot + 1, rightIndex);

    //     return values;
    // }
}
