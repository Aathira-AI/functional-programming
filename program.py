names = [
    "Sam",
    "John",
    "Steve",
    "Alice",
    "Sarah",
    "Bob"
]

results = []

for i in range(len(names)):
    if names[i].startswith("S"):
        results.append(names[i])

for name in results:
    print(name)
