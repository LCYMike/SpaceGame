using UnityEngine;

public class Manager : MonoBehaviour {

    private int healthMotherShip = 100;
    private int healthPlayer = 20;

    public PlayerController player;
    public MotherShipController ship;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            PlayerHit(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)){
            PlayerHit(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)){
            PlayerHit(3);
        }
    }

    public void PlayerHit(int tag)
    {

        switch (tag)
        {
            case 1:
                healthPlayer -= 5;
                break;
            case 2:
                healthPlayer -= 10;
                break;
            case 3:
                healthPlayer -= 5;
                break;
        }

        if (healthPlayer <= 0)
        {
            player.Die();
        }

    }

    public void ShipHit(int tag)
    {

        switch (tag)
        {
            case 1:
                healthPlayer -= 5;
                break;
            case 2:
                healthPlayer -= 10;
                break;
            case 3:
                healthPlayer -= 5;
                break;
        }

        if (healthMotherShip <= 0)
        {
            ship.Die();
        }

    }

}
