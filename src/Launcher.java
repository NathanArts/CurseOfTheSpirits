import models.entities.Player;
import models.entities.Spirit;

/**
 * Test launcher
 */
public class Launcher {
    public static void main(String[] args) {
        Player me = new Player("Michael");
        Spirit trap = new Spirit("Yuu-chan");
        me.setSpirit(trap);
        trap.setVictim(me);

        me.getBody().getBodyPart("Asshole");

    }
}
