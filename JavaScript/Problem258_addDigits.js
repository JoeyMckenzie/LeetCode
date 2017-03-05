console.time("Execution time");

var addDigits = function(nums) {
    // Trivial digital root solution:
    // return ((nums-1) % 9)+1;
    
    // Iterative solution
    // Convert input to character array
    var numString = nums.toString().split("");
    
    // Initialize sum
    var sum = 0;
    
    // Find the sum of the digits of the intial input
    for (var i = 0; i < numString.length; i++) {
        sum += parseInt(numString[i],10);
    }
    
    var sumString = sum.toString().split("");
    
    while (sumString.length > 1) {
        var newSum = 0;
        for (var i = 0; i < sumString.length; i++) {
            newSum += parseInt(sumString[i],10);
        }     
        sumString = newSum.toString().split("");
    }
    return parseInt(sumString);        
};
console.log(addDigits(1853));

console.timeEnd("Execution time")