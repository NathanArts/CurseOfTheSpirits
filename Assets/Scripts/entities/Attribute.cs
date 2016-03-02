namespace entities {
	/**
	 * This class manages the attributes of an entity.
	 */
	public class Attribute {
	    private int basis;
	    private int bonus;
	    private int max;

	    public Attribute(int basis, int max) {
	        this.basis = basis;
	        this.bonus = 0;
	        this.max = max;
	    }

	    public int getSum() {
	        if (basis + bonus > max) {
	            return max;
	        } else if (basis + bonus < 0) {
	            return  0;
	        } else {
	            return basis + bonus;
	        }
	    }

	    public int getBasis() {
	        return basis;
	    }

	    public void addBasis(int value) {
	        if (basis + value > max) {
	            basis = max;
	        } else if (basis + value < 0) {
	            basis = 0;
	        } else {
	            basis += value;
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
}