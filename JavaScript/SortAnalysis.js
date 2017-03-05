/*
  Analysis of sort methods in JavaScript
*/

var sortMethods = {
  // Quicksort methods
  quickSort: function(nums) {
    // base case to end recursion once array is sorted
    if (nums.length < 2) {
      return nums;
    } else {
      // Selecting a random a partition value to serve as the pivot for the sort
      var pivot = Math.floor(Math.random() * nums.length);

      // Initializing arrays to store values smaller/greater than the pivot value,
      // as well as sorted array
      var smaller = [];
      var greater = [];
      var sorted = [];

      // Iterating through input array, comparing with pivot value, and storing in
      // proper array (smaller or greater)
      for (var i = 0; i < nums.length; i++) {
        if (nums[i] <= pivot) {
          smaller.push(nums[i]);
        } else {
          greater.push(nums[i]);
        }
      }

      // Filling sorted arrray with partially sorted values

      sorted = sorted.concat(this.quickSort(smaller));
      sorted.push(pivot);
      sorted = sorted.concat(this.quickSort(greater));

      return sorted;
    }
  }
}

// Generating a list of size n with values ranging from [1,n]
list = []
n = Math.pow(10,1);
for (var i = 0; i < n; i++) {
  list[i] = Math.floor(Math.random() * n);
}

// Quicksort analysis
console.time("Quicksort");
sortMethods.quickSort(list);
console.timeEnd("Quicksort");
