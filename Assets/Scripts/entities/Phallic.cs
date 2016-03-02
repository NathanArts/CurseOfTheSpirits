namespace entities {

	/**
	 * Objects of Subclasses of this class are able to penetrate Fuckable BodyParts
	 */
	public interface Phallic {
	    /**
	     * size in cm
	     */
		int size {
			get;
			set;
		}
	    /**
	     * width in mm
	     */
		int width {
			get;
			set;
		}

        bool startPenetrating(Fuckable orifice);
        bool stopPenetrating(Fuckable orifice);
    }
}
