# Day 1: Historian Hysteria — Part Two

Your analysis only confirmed what everyone feared: the two lists of location IDs are indeed very different.

Or are they?

---

### New Observation
The Historians can't agree on which group made the mistakes or how to read most of the Chief's handwriting. However, in the commotion, you notice an interesting detail: many location IDs appear in both lists! It’s possible that the other numbers aren't location IDs at all but rather misinterpreted handwriting.

---

### Problem: Similarity Score
This time, you'll need to calculate a **similarity score** based on the overlap between the two lists. Specifically:

1. For each number in the left list, count how many times it appears in the right list.
2. Multiply the number from the left list by the count from the right list.
3. Add these products to calculate the **total similarity score**.

---

### Example Input

Here are the same example lists:

| Left List | Right List |
|-----------|------------|
| 3         | 4          |
| 4         | 3          |
| 2         | 5          |
| 1         | 3          |
| 3         | 9          |
| 3         | 3          |

---

### Example Calculation

1. **Number: 3**
   - Appears in the right list **3 times**.
   - Contribution to similarity score: `3 * 3 = 9`.

2. **Number: 4**
   - Appears in the right list **1 time**.
   - Contribution to similarity score: `4 * 1 = 4`.

3. **Number: 2**
   - Appears in the right list **0 times**.
   - Contribution to similarity score: `2 * 0 = 0`.

4. **Number: 1**
   - Appears in the right list **0 times**.
   - Contribution to similarity score: `1 * 0 = 0`.

5. **Number: 3 (again)**
   - Appears in the right list **3 times**.
   - Contribution to similarity score: `3 * 3 = 9`.

6. **Number: 3 (again)**
   - Appears in the right list **3 times**.
   - Contribution to similarity score: `3 * 3 = 9`.

**Total Similarity Score** = `9 + 4 + 0 + 0 + 9 + 9 = 31`.

---

### Task

Using your actual left and right lists, calculate the **total similarity score**.
