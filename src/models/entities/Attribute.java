package models.entities;

/**
 * This class manages the attributes of an entity.
 */
public class Attribute {
    private int base;
    private int bonus;
    private int max;

    public Attribute(int base, int max) {
        this.base = base;
        this.bonus = 0;
        this.max = max;
    }

    public int getSum() {
        if (base + bonus > max) {
            return max;
        } else if (base + bonus < 0) {
            return  0;
        } else {
            return base + bonus;
        }
    }

    public int getBase() {
        return base;
    }

    public void addBase(int value) {
        if (base + value > max) {
            base = max;
        } else if (base + value < 0) {
            base = 0;
        } else {
            base += value;
        }
    }

    public int getBonus() {
        return bonus;
    }

    public void addBonus(int bonus) {
        this.bonus += bonus;
    }

    public void removeBonus(int bonus) {
        this.bonus -= bonus;
    }
}
