using UnityEngine;

public class Laser : MonoBehaviour {

    public float velocity = 10f;

    private Obstacle obs;

    private void Start()
    {
        obs = FindObjectOfType<Obstacle>();
    }

    void Update () {
        transform.Translate(Vector3.right * velocity * Time.deltaTime);

        if (transform.position.x > 25)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }
}
