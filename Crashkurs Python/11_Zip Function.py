# 1, 'eins'
# 3, 'drei'
# 5, 'fünf'
# 7, 'sieben'
# 9, 'neun'

words = ['eins', 'drei', 'fünf', 'sieben', 'neun']
numbers = range(1, 10, 2)

both = zip(numbers, words)

for number, word in both:
    print(number, word, sep=' und ')
