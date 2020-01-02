a = [3, 5, -2, 8, 12, 0, -1]

print(a)

a.append(20)
print(a)

a.remove(8)
print(a)

a.pop(2)
print(a)

a.insert(1, 40)
print(a)

pos = a.index(0)
print(pos)

print(a[:pos])
print(a[pos+1:])

a.reverse();
print(a)
