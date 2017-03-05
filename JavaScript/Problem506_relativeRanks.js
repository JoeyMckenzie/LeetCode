/*
Problem 506: Given scores of N athletes, find their relative ranks and the people with the top three highest scores, 
who will be awarded medals: "Gold Medal", "Silver Medal" and "Bronze Medal".

Example:
[1,5,2,6,3] --> ["5", "Silver Medal", "4", "Gold Medal", "Bronze Medal"]
*/
console.time("Execution time");

var findRelativeRanks = function(nums) {
    // Declaring return string array and List for quick index access (2n space)
	var numString = [];
	var numsUnsorted = []
	for (var i = 0; i < nums.length; i++) {
	    numsUnsorted[i] = nums[i];
	}
	
    nums.sort();
	
	// Assigning ranks to return string based on value and placement inside the List
	for (var i = nums.length-1; i >= 0; i--) {
		var rank = nums.length-i;
		console.log(rank);
		if (i === nums.length-1) { numString[numsUnsorted.indexOf(nums[i])] = "Gold Medal"; } 
		else if (i === nums.length-2) { numString[numsUnsorted.indexOf(nums[i])] = "Silver Medal"; } 
		else if (i === nums.length-3) { numString[numsUnsorted.indexOf(nums[i])] = "Bronze Medal"; } 
		else { numString[numsUnsorted.indexOf(nums[i])] = rank.toString(); }
	}
	
	return numString;
};

console.log(findRelativeRanks([5,4,3,2,1]));
console.timeEnd("Execution time");