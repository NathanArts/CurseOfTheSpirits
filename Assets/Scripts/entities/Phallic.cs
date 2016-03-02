namespace entities {

	/**
	 * Objects of Subclasses of this class are able to penetrate Fuckable BodyParts
	 */
	public interface Phallic {
        /**
	     * name for identification
         */
        string name {
            get;
        }
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

        bool Equals(object obj);
        int GetHashCode();
    }
}
