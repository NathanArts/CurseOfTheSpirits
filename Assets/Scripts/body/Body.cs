using System;
using System.Collections.Generic;

namespace body {
	/**
	 * This class represents the body of an entity.
	 * It consists of the different BodyParts and will be changed.
	 * Possible features could be fuckable bodyparts, limbs, etc
	 */
	public class Body {
	    private Dictionary<string, BodyPart> bodyParts;

	    public Body() {
			bodyParts = new Dictionary<string, BodyPart>();
	    }

	    public Body(Dictionary<String, BodyPart> bodyParts) {
	        this.bodyParts = bodyParts;
	    }

	    public BodyPart getBodyPart(String name) {
	        return bodyParts[name];
	    }

	    public void addBodyPart(String name, BodyPart bodyPart) {
	        bodyParts.Add(name, bodyPart);
	    }
	}
}