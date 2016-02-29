package models.entities;

import models.body.Body;

/**
 * Abstract class for all entities in the game.
 * Includes minimum stats set, a body and a name
 */
public abstract class Entity {
    protected String name;
    protected Attribute strength;
    protected Attribute dexterity;
    protected Attribute endurance;
    protected Attribute intelligence;
    protected Attribute will;
    protected Attribute charisma;
    protected Attribute libido;
    protected Attribute sensitivity;
    protected Attribute lust;
    protected Body body;

    public Entity(String name) {
        this.name = name;
        strength = new Attribute(0, 100);
        dexterity = new Attribute(0, 100);
        endurance = new Attribute(0, 100);
        intelligence = new Attribute(0, 100);
        will = new Attribute(0, 100);
        charisma = new Attribute(0, 100);
        libido = new Attribute(0, 100);
        sensitivity = new Attribute(0, 100);
        lust = new Attribute(0, 100);
        body = new Body();
    }

    public String getName() {
        return name;
    }

    public Attribute getStrength() {
        return strength;
    }

    public Attribute getDexterity() {
        return dexterity;
    }

    public Attribute getEndurance() {
        return endurance;
    }

    public Attribute getIntelligence() {
        return intelligence;
    }

    public Attribute getWill() {
        return will;
    }

    public Attribute getCharisma() {
        return charisma;
    }

    public Attribute getLibido() {
        return libido;
    }

    public Attribute getSensitivity() {
        return sensitivity;
    }

    public Attribute getLust() {
        return lust;
    }

    public Body getBody() {
        return body;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Entity)) return false;

        Entity entity = (Entity) o;

        return name.equals(entity.name);

    }

    @Override
    public int hashCode() {
        return name.hashCode();
    }
}
