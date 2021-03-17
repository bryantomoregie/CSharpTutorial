using System;
public class Sorted {

	public static int[] SortedSquaredArray(int[] array) {
		int length = array.Length;
		int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = array[i] * array[i];
        }
		return arr;
	}
}
