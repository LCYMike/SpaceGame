using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private float velocity;

    private Manager manager;

    private void Start()
    {
        manager = FindObjectOfType<Manager>();
        velocity = Random.Range(2f, 4f);
    }

    private void Update()
    {
        transform.Translate((Vector3.left * velocity) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Projectile")
        {
            Debug.Log("Projectile");
            Destroy(gameObject);
        }

        if (other.transform.tag == "Player")
        {
            Debug.Log("Player");
            manager.PlayerHit(1);
            Destroy(gameObject);
        }

        if (other.transform.tag == "MotherShip")
        {
            Debug.Log("MotherShip");
            manager.ShipHit(1);
            Destroy(gameObject);
        }

    }

}
