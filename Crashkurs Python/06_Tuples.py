# Tuplen

def pow(x):
    return x**2, x**3, x**4

square, cubic, pow4 = pow(3)
print(square, cubic, pow4, sep=',')

values = pow(3)
print(values[0],values[1],values[2],sep=',')

# Max Huber hat 78.5 kg und ist 175 cm groß.
# Ida Krammer hat 76.1 kg und ist 182 cm groß.

#tuple packing
p1 = 'Max', 'Huber', 78.5, 175
p2 = 'Ida', 'Krammer', 76.1, 182

print(p1)
print(p2)

print(p1[1], p2[1])

print((p1[3]+p2[3])/2, "cm")

# tuple sind immutable, wie String in Java und C#
#p1[2]+=2