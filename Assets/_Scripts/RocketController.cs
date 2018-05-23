using UnityEngine;

public class RocketController : MonoBehaviour {

    public float thrust = 1f;
    private float distance = 1.5f;

    private float cooldown = 0.2f;

    public CameraController cam;

    void Start () {
        cam = FindObjectOfType<CameraController>();
	}

    void FixedUpdate()
    {
        float x = transform.position.x;

        //Upward Movement
        transform.Translate(new Vector2(0, (thrust / 10) * Time.deltaTime));

        cooldown = cooldown -= Time.deltaTime;

        //Controld for going Left & Right
        if (cooldown <= 0)
        {
            //Checks position and input
            if (Input.GetKeyDown(KeyCode.A) && x > -1)
            {
                //Moves Player
                transform.Translate(new Vector2(-distance, 0));

                //Corrects Camera So it will stay in it's position
                cam.goLeft(distance);

                //resets cooldown
                cooldown = 0.2f;
            }

            //Checks position and input
            if (Input.GetKeyDown(KeyCode.D) && x < 1)
            {
                //Moves Player
                transform.Translate(new Vector2(distance, 0));

                //Corrects Camera So it will stay in it's position
                cam.goRight(-distance);

                //resets cooldown
                cooldown = 0.2f;
            }

        }

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            Debug.Log("We hit : " + col.transform.name);
        }
    }

}