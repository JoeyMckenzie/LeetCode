=begin

Problem 506: Given scores of N athletes, find their relative ranks and the people with the top three highest scores, 
who will be awarded medals: "Gold Medal", "Silver Medal" and "Bronze Medal".

Example:
[1,5,2,6,3] --> ["5", "Silver Medal", "4", "Gold Medal", "Bronze Medal"]

=end


class RelativeRanks
    def find_relative_ranks(nums)
        # Initializing return string array
        nums_string = []
        # My solution: sort the array using .sort (pretty sure ruby uses quicksort, see Quicksort_Analysis.rb 
        # for a quick comparison of the two)
        nums_sorted = nums.sort
        
        # Iterating through sorted and assigning ranks
        i = 0
        (nums.length-1).downto(0) do
            i += 1
		    rank = nums.length-i;
    		 if i == nums.length-1
    		     nums_string[nums.index(nums_sorted[i])] = "Gold Medal"
    		 elsif i == nums.length-2
    		     nums_string[nums.index(nums_sorted[i])] = "Silver Medal"
    		 elsif i == nums.length-3
    		    nums_string[nums.index(nums_sorted[i])] = "Bronze Medal" 
    		 else
    		     nums_string[nums.index(nums_sorted[i])] = rank.to_s
    		 end
		end
		return nums_string
    end
end

test_prob = RelativeRanks.new
puts test_prob.find_relative_ranks([1,4,5,2,3])
    