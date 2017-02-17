t_0 = Time.now

class Problem479_LargestPalindrome
  def largest_palindrome(n)
    upper = 10**n - 1
    lower = 10**(n-1)
    biggest = current = 0
    for i in lower..upper
      for j in lower...i
        product = i*j
        product.to_s.reverse != product.to_s || (product < lower**2 || product > upper**2) ? next : current = product
        biggest = current if current > biggest
      end
    end
    return biggest % 1337
  end
end
largest_palindrome = Problem479_LargestPalindrome.new
puts largest_palindrome.largest_palindrome(3)


t_1 = Time.now
diff = (t_1 - t_0) * 1E3
puts "Execution time: #{diff} ms"
