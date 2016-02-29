package models.body;

import java.util.HashMap;

/**
 * This class represents the body of an entity.
 * It consists of the different BodyParts and will be changed.
 * Possible features could be fuckable bodyparts, limbs, etc
 */
public class Body {
    private HashMap<String, BodyPart> bodyParts;

    public Body() {
        bodyParts = new HashMap<>();
    }

    public Body(HashMap<String, BodyPart> bodyParts) {
        this.bodyParts = bodyParts;
    }

    public BodyPart getBodyPart(String name) {
        return bodyParts.get(name);
    }

    public BodyPart addBodyPart(String name, BodyPart bodyPart) {
        return bodyParts.put(name, bodyPart);
    }
}
