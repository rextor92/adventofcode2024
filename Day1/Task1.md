# Day 1: Historian Hysteria

The Chief Historian is always present for the big Christmas sleigh launch, but nobody has seen him in months! Last anyone heard, he was visiting locations that are historically significant to the North Pole. A group of Senior Historians has asked you to accompany them as they check the places they think he was most likely to visit.

## Collecting Stars
The Historians need to collect **50 stars** by solving puzzles in order to save Christmas. Two puzzles will be available each day in the Advent calendar, and completing each puzzle grants one star. The second puzzle is unlocked after completing the first. 

---

### Problem: Reconciling Lists
The group of Elvish Senior Historians has hit their first problem: their list of locations to check is currently empty. Upon searching the Chief Historian's office, they discover an assortment of notes and lists of historically significant locations. These notes list locations by unique numbers called **location IDs**.

Two groups of Historians worked independently to compile their lists, but their results are different. To reconcile these lists, we need to calculate the **total distance** between them.

---

### Example Input

Here are two lists of location IDs:

| Left List | Right List |
|-----------|------------|
| 3         | 4          |
| 4         | 3          |
| 2         | 5          |
| 1         | 3          |
| 3         | 9          |
| 3         | 3          |

---

### Process

1. **Sort both lists.**
2. Pair up the smallest number in the left list with the smallest number in the right list, the second smallest with the second smallest, and so on.
3. For each pair, calculate the absolute difference between the two numbers.
4. Add up all these differences to get the total distance.

---

### Example Calculation

Given the sorted lists:

| Left List | Right List |
|-----------|------------|
| 1         | 3          |
| 2         | 3          |
| 3         | 3          |
| 3         | 4          |
| 3         | 5          |
| 4         | 9          |

The pairs and their distances are:

- Pair (1, 3): Distance = |1 - 3| = 2
- Pair (2, 3): Distance = |2 - 3| = 1
- Pair (3, 3): Distance = |3 - 3| = 0
- Pair (3, 4): Distance = |3 - 4| = 1
- Pair (3, 5): Distance = |3 - 5| = 2
- Pair (4, 9): Distance = |4 - 9| = 5

**Total Distance** = 2 + 1 + 0 + 1 + 2 + 5 = **11**

---

### Task

Your actual left and right lists contain many location IDs. Calculate the total distance between the two lists.
