package models.entities;

/**
 * Objects of Subclasses of this class are able to penetrate Fuckable BodyParts
 */
public interface Phallic {
    /**
     * size in cm
     */
    int size = 0;
    /**
     * width in mm
     */
    int width = 0;

    public int getSize();

    public int getWidth();
}
