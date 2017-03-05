=begin

For a web developer, it is very important to know how to design a web page's size. So, given a specific rectangular web page’s area, your job by now is to design a rectangular web page, whose length L and width W satisfy the following requirements:

1. The area of the rectangular web page you designed must equal to the given target area.

2. The width W should not be larger than the length L, which means L >= W.

3. The difference between length L and width W should be as small as possible.
You need to output the length L and the width W of the web page you designed in sequence.

Example:
Input: 4
Output: [2, 2]
Explanation: The target area is 4, and all the possible ways to construct it are [1,4], [2,2], [4,1]. 
But according to requirement 2, [1,4] is illegal; according to requirement 3,  
[4,1] is not optimal compared to [2,2]. So the length L is 2, and the width W is 2.

=end

t_0 = Time.now

def construct_rectangle(area)
    # Initializing minimal difference to check against
    minimal_diff = area
    
    # Setting the maximum possible value for the width as both dimensions are 
    # integer factors of the area (width is less than than the root, while the length is greater than the root)
    max_w = (area**(0.5)).ceil
    
    # Iterating through factors
    for w in 1..max_w
        l = (area/w).to_i
        
        # Updating minmum difference each iteration if a possible factor is found
        # and returning the smalling difference found
        if (area % l == 0 && l*w == area && l >= w)
            diff = l-w
            if diff < minimal_diff
                minimal_diff = diff
                minimal_l = l
                minimal_w = w
            end
        end
    end
    
    # Implicit return FTW
    dimensions = [minimal_l, minimal_w]
end

puts construct_rectangle(1E7)

t_1 = Time.now
time_diff = (t_1 - t_0) * 1E3
puts "Execution time: #{time_diff} ms"