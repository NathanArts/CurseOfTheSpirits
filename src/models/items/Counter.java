package models.items;

/**
 * Model the behavior of items in the backpack.
 * It can be incremented or decremented by a given value but never below 0 or above it's maximum
 * It can also be set to zero.
 */
public class Counter {
    private int itemCount;
    private int max;

    public Counter(int max) {
        this.itemCount = 1;
        this.max = max;
    }

    public int getItemCount() {
        return itemCount;
    }

    public boolean add(int diff) {
        if (this.itemCount + diff > this.max && this.itemCount + diff >= 0) {
            return false;
        } else {
            this.itemCount += diff;
            return true;
        }
    }

    public void setToZero() {
        this.itemCount = 0;
    }

    public boolean isZero() {
        return this.itemCount == 0;
    }
}
