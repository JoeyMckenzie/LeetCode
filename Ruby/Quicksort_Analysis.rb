=begin

A quick analysis and comparison of the quicksort algorithm
and the intrinsic .sort method in Ruby, for the curious.

The idea behind quicksort: given an array, partition into smaller subset array by
selecting a pivot point (input serving as the dividing line). Compare values in the
subset arrays to the pivot value, sorting by greater/lesser values into subset arrays.
Using recursion, keep subsetting and comparing until all values are sorted.

Time complexity: ~O(n log n)

=end

class Quicksort_Analysis
	def quicksort(array)
	    # base case to break recursion once values are sorted and return sorted array
	    if array.length <= 1
	        return array
        else
    	    # initializing a random pivot value in the array to serve as the partition
    	    # with .sample method and removing it
    	    part = array.sample
    	    array.delete_at(array.index(part));

    	    # Initializing comparison arrays to sort greater/lesser values
    	    smaller = []
    	    bigger = []

    	    # Running the comparison
    	    array.each do |i|
    	        if i >= part
    	            bigger << i
    	        else
    	            smaller << i
    	        end
    	    end

    	    # Using recursion to sort subset arrays
    	    # Initializing sorted array
    	    sorted = []

    	    # Appending with smaller values subset, the partition value, and greater values subset in that order
    	    sorted << self.quicksort(smaller)
    	    sorted << part
            sorted << self.quicksort(bigger)

    	    # Sorted is a now a nested array of sorted values, we use .flatten to remove the nesting,
    	    # leaving behind just the values
    	    sorted.flatten!
    	    return sorted
  		end
	end
end

# Testing quicksort with random array of magnitude size n with inputs in range [1,10**n]
n = 5
inputs = 10**n
list = []

# filling array
inputs.times do |elem|
    list << rand(inputs)
end

# Timing exection
t_0 = Time.now

quicksort_test = Quicksort_Analysis.new
quicksort_test.quicksort(list)

t_1 = Time.now
diff_quicksort = (t_1 - t_0) * 1E3
puts "Execution time with quicksort: #{diff_quicksort} ms"

t_2 = Time.now
list.sort!
t_3 = Time.now

diff_sort = (t_3 - t_2) * 1E3
puts "Execution time with ruby .sort: #{diff_sort} ms"
