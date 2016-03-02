using items;

namespace body {
	/**
	 * well, it's an asshole. What do you expect
	 */
	public class Asshole : FuckableBodyPart {
	    public Asshole(Item item, string description, int capacity = 1, int sensivity = 1, int wettness = 0) 
		    	: base(item, description, capacity, sensivity, wettness) {
	    }
	}
}
