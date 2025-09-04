# Create a list of tuples (points with x and y coordinates)
points = [(1, 2), (5, 8), (3, 4), (7, 2), (6, 6)]

# Iterate through the list of points
for x, y in points:
    if x > y:
        print(f"The X coordinate is greater than the Y coordinate for point ({x}, {y}).")
    else:
        print(f"The Y coordinate is greater than or equal to the X coordinate for point ({x}, {y}).")