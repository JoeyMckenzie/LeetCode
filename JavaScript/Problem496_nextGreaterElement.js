/*
  Problem 496: Given an integer array and a subset of the same array, find the
  next greater number for each element of the subset array. The next greater number
  of each element is the next greatest number to the right of the input array
  relative to the current element. If the current element does not have a next greater
  number, return -1. For example:

  Input array: [1,3,4,2]
  Subset array: [4,1,2]
  Next greater element of Subset array: [-1,3,-1]

  Solution: In the subset array, [4,1,2], there is no number greater than 4 to the right
  of it's position in the input array, so we return -1 in the next greater number array.
  The next greater number to 1 in the subset array is 3, as it the first bigger number
  to the right of 1. There are no numbers greater than 2 to the right of 2, so we return -1.
*/

var Problem496_nextGreaterElement = {
	nextGreaterElement: function(findNums, nums) {
    // If given an array without inputs, return an empty set
		if (nums.length === 0) return [];
    // Initializing next greater number array
		var nextGreaterNumber = [];
		console.log("nums: " + nums);
		console.log("findNums: " + findNums);

    // Traverse the subset array, find it's relative position in the input array,
    // and return the first number that is greater than it - up to O(mn) time
		for (var i = 0; i < findNums.length; i++) {
      // If at the last element, return -1 to the next greater number array
			if (findNums[i+1] === undefined) nextGreaterNumber[i] = -1;
      // Using indexOf for quick element access in input array
			for (var k = nums.indexOf(findNums[i]); k < nums.length; k++) {
        // breaking as soon as first greatest number is found
				if (nums[k] > findNums[i]) { nextGreaterNumber[i] = nums[k]; break; }
			}
      // If no number was found (no greater number) return -1
			if (nextGreaterNumber[i] === undefined) nextGreaterNumber[i] = -1;
		}
		console.log("nextGreaterNumber: " + nextGreaterNumber);
		return nextGreaterNumber;
	}
}

Problem496_nextGreaterElement.nextGreaterElement([4,1,2], [1,3,4,2]);
