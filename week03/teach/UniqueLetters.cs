﻿public static class UniqueLetters {
    public static void Run() {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        Console.WriteLine(AreUniqueLetters(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        Console.WriteLine(AreUniqueLetters(test2));

        var test3 = "";
        Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    private static bool AreUniqueLetters(string text) {
        // TODO Problem 1 - Replace the O(n^2) algorithm to use sets and O(n) efficiency
        HashSet<string> mySet = new HashSet<string>();
        for (var i = 0; i < text.Length; ++i) {
            string letter = text[i].ToString();
            
            if (!mySet.Add(letter)) {
                return false;
            }
        }

        return true;
    }
}