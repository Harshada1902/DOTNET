using System;

class Jagged {

    public static void Main()
    {

        // Declare the Jagged Array of four elements:
        int[][] jagged_arr = new int[4][];

        // Initialize the elements
        jagged_arr[0] = new int[] { 1, 2, 3 };
        jagged_arr[1] = new int[] { 4,5 };
        jagged_arr[2] = new int[] { 8,9,10,11};
        jagged_arr[3] = new int[] { 0,14,15};

        // Display the array elements:
        for (int n = 0; n < jagged_arr.Length; n++) {

            // Print the row number
            System.Console.Write("Row({0}): ", n);

            for (int k = 0; k < jagged_arr[n].Length; k++) {

                // Print the elements in the row
                System.Console.Write("{0} ",
                                     jagged_arr[n][k]);
            }
            System.Console.WriteLine();
        }
    }
}