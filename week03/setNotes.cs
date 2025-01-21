// Set - no duplicates
// index(n) = n
// index(n) = n % 10 (can change 10 to something else
// .GetHashCode()
// Sets have the following key characteristics:

// Fast performance for adding, removing, and finding (membership test).
// No duplicates are allowed. Most set implementations (including C#) will not give us an error when you try to add a duplicate value. This is done so that we can easily convert from a list, which may have duplicates, to a set that contains just the unique values.
// The set does not keep values in order. This occurs because the index(n) hashing function is not based on the order the value was added.
// Sets have many uses, including the following:

// Finding the unique values in a list.
// Providing quick access to unique results previously calculated.
// Performing mathematical set operations such as an intersection (common values between two sets) and union (all values within two sets).

// .Add(value) .Remove(value) .Contains(value) .Count
// set1.Intersect(set2).ToHashSet()
// set1.Union(set2).ToHashSet()

// chaining
// A method of removing conflicts in a set in which all items that hash to the same index are chained together into a single data structure stored in that target index. When looking for data, the code will need to traverse the data structure.

// hashing
// The process of mapping an item to an index location using a hashing function. Since the function does not require searching through the data structure, hashing can result in an O(1) in the best case.

// hashing function
// A function that converts the value of an item to a numerical index value. The hashing function will include a modulo operation to ensure the resulting index is within range of the sparse array.

// open addressing
// A method of removing conflicts in a set in which a new empty location is found elsewhere in the sparse array. There are multiple ways of finding an empty location including moving over 1 index at a time until one is found. When looking for data, the code will need to follow this search strategy until something is found.

// set
// A data structure that maps data to an index based on a hashing function. Sets can only hold unique data because of the hashing function. Sets are useful for summarizing data and finding duplicates.

// sparse array
// An array that is only partially filled. To avoid conflicts in a set, a sparse array must have sufficient empty space to allow for new additions. If a sparse array gets too full, a large sparse array could be created with an updated hashing function.