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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create an array of doubles with a size equal to the given length.
        // Step 2: Loop from i = 0 to length -1 to populate each element of the array.
        // Step 3: Inside the loop, calculate the multiple by multiplying the starting 'number' by (i + 1).
        // Step 4: Assign the calculated multiple to the array at the current index i.
        // Step 5: After the loop finishes, return the completed array.

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    
        // Step 1: Check if the list is null, empty, or if the amount is 0; if so, exit early since no rotation is needed.
        // Step 2: Calculate the starting index of the elements that need to be moved to the front, which is (data.Count - amount).
        // Step 3: Extract the sublist of elements from the end of the list using GetRange starting from that index with length 'amount'.
        // Step 4: Remove those elements from the end of the original list using RemoveRange.
        // Step 5: Insert the extracted sublist at the very beginning of the lsit (index 0) using InsertRange, which completes the right rotation in place.

        if (data == null || data.Count == 0 || amount <= 0)
            return;

        amount = amount % data.Count;
        if (amount == 0)
            return;

        int startIndex = data.Count - amount;
        List<int> tailElements = data.GetRange(startIndex, amount);
        data.RemoveRange(startIndex, amount);
        data.InsertRange(0, tailElements);
}
}
