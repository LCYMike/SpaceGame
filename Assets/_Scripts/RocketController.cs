using UnityEngine;

public class RocketController : MonoBehaviour {

    public float thrust = 1f;
    private float distance = 1.5f;

    private bool isLeft = false;
    private bool isRight = false;

    public CameraController cam;

    Rigidbody2D rb;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        cam = FindObjectOfType<CameraController>();
	}
	
	void FixedUpdate ()
    {
        //Upward Movement
        transform.Translate(new Vector2(0, (thrust / 10) * Time.deltaTime));



        //Controld for going Left

        //Checks position and input
        if (Input.GetKeyDown(KeyCode.A) && !isLeft)
        {
            //Moves Player
            transform.Translate(new Vector2(-distance, 0));

            //Corrects Camera So it will stay in it's position
            cam.goLeft(distance);

            //Checks the position
            if (isRight)
            {
                isLeft = false;
            }
            else
            {
                isLeft = true;
            }

            if (isRight)
                isRight = false;
        }

        //Controld for going Right

        //Checks position and input
        if (Input.GetKeyDown(KeyCode.D) && !isRight)
        {
            //Moves Player
            transform.Translate(new Vector2(distance, 0));

            //Corrects Camera So it will stay in it's position
            cam.goRight(-distance);

            //Checks the position
            if (isLeft)
            {
                isRight = false;
            } else
            {
                isRight = true;
            }

            if (isLeft)
                isLeft = false;
        }
    }
}