/*
  Problem 448: Given an array with inputs ranging from [1,n], n being the array length, some elements appear twice,
  some only once, and some not at all. Find the missing elements.

	Solution using array negation: As the bounds of this problem are [1,n],
	we assume the array elements are assinged idicies; indicies not assigned are
	the missing elements in the array. Iterating through the array, assigned indicies
	have their signs flipped. Running through the array once more, positive elements
	point to indicies not present in the array, and thus are the missing elements .push'ed
	to a new array of linear space complexity O(n).

  I took a different approach to this problem than my C# solution, as using .contains
  in JS is much slower than the similar list interface offered in .NET
*/


var Problem448_disappearedNumbers = {
	findDisappearedNumbers: function(nums) {
		// Initializing return array
		var numsDisappeared = [];

    // Interating through the input array first, flipping the sign
		for (var i = 0; i < nums.length; i++) {
      // Initializing index of all entries in the array, using nums[i]-1 since arrays are 0-based
			var index = Math.abs(nums[i])-1;
      // If the index was previously assigned, go to the next iteration
			nums[index] > 0 ? nums[index] = -nums[index] : false;
		}

    // Iterating through the array once more, picking up elements that did not have their signs flipped
		for (var i = 0; i < nums.length; i++) {
			nums[i] > 0 ? numsDisappeared.push(i+1) : false; // .push(i+1) to offset 0-based indexing
		}
		console.log("numsDisappeared: " + numsDisappeared);
	}
};

Problem448_disappearedNumbers.findDisappearedNumbers([4,3,2,7,8,2,3,1]);
