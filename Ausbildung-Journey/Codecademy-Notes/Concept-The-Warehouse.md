# 📦 The Warehouse: Arrays & Lists

In CargoNerds, we don't just inspect containers. We **store** them.

## 1. The Variable (The Hand) ✋
One box at a time.
`int price = 200;`
*   **Problem:** If you pick up a new box, you drop the old one.

## 2. The Array (The Rack) 🏗️
A fixed metal rack with numbered slots.
`int[] prices = new int[5];`
*   **Good:** Fast.
*   **Bad:** You must decide the size (5) *before* you start.
*   **Real World:** "We have exactly 5 parking spots."

## 3. The List (The Magic Bag) 🎒
A bag that grows as you fill it.
`List<int> prices = new List<int>();`
*   **Good:** Can hold 0 items or 10,000 items.
*   **Usage:**
    *   `prices.Add(200);`  (Store it)
    *   `prices.Count;`     (How many?)
    *   `prices.Sum();`     (Total$$)
*   **Real World:** "A session of unknown length."

**For Pricing Manager:**
We don't know if Maersk will send 1 container or 100.
So we use a **List**.
