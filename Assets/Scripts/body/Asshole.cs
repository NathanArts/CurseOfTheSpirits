using items;

namespace body {
	/**
	 * well, it's an asshole. What do you expect
	 */
	public class Asshole : Fuckable {
		public Asshole(Item item, string description) : base(item, description) {
	        
	    }

	    public Asshole(Item item, string description, int capacity, int sensivity, int wettness) 
			: base(item, description, capacity, sensivity, wettness) {

	    }
	}
}
