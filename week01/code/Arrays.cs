public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Declare a new array that will be returned after loop completes
        double[] result = new double[length];
        // Create a loop for each integer, starting at 1 and ending at variable 'length'
        for (int i = 0; i < length; i++)
        {
            // Multiply i+1 by the variable 'number'
            double value = (i + 1) * number;
            // Append that result to array at index value i
            result[i] = value;
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Loop over list an amount of times equal to the amount of shifted positions
        for (int i = 0; i < amount; i++)
        {
            // Save value at end of list in a variable
            int saved = data[data.Count - 1];
            // Remove value at end of list
            data.RemoveAt(data.Count - 1);
            // Add that value to the beginning of list to complete one right shift before loop either repeats or concludes
            data.Insert(0, saved);
        }
    }
}
//  --test 