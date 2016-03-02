using System;
using System.Collections.Generic;
using entities;

namespace body {
	/**
	 * This class represents the body of an entity.
	 * It consists of the different BodyParts and will be changed.
	 * Possible features could be fuckable bodyparts, limbs, etc
	 */
	public class Body {
	    private Dictionary<string, BodyPart> BodyParts;

        public Dictionary<string, BodyPart> bodyParts {
            get { return this.BodyParts; }
        }

        public Body(Dictionary<String, BodyPart> bodyParts = null) {
            if (bodyParts == null) {
                bodyParts = new Dictionary<string, BodyPart>();
            } else {
                this.BodyParts = bodyParts;
            }
        }

        public List<Phallic> findPhallicBodyParts() {
            List<Phallic> phallics = new List<Phallic>();
            foreach (BodyPart bodyPart in this.bodyParts.Values) {
                if (bodyPart is PhallicBodyPart) {
                    phallics.Add((PhallicBodyPart) bodyPart);
                }
            }
            return phallics;
        }

        public List<Fuckable> findFuckableBodyParts() {
            List<Fuckable> fuckables = new List<Fuckable>();
            foreach (BodyPart bodyPart in this.bodyParts.Values) {
                if (bodyPart is FuckableBodyPart) {
                    fuckables.Add((FuckableBodyPart) bodyPart);
                }
            }
            return fuckables;
        }
    }
}