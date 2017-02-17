# @param {Integer} n
# @return {String[]}
def fizz_buzz(n)
  list = []
  for i in 1..n
    if i % 15 == 0
      list.push("FizzBuzz")
    elsif i % 3 == 0
      list.push("Fizz")
    elsif i % 5 == 0
      list.push("Buzz")
    else
      list.push(i.to_s)
    end
  end
  return list
end

puts fizz_buzz(100)