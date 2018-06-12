using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject laser;

    private float cooldown = 0.33f;

	void Update () {

        cooldown = cooldown - Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && cooldown <= 0)
        {
            cooldown = 0.33f;
            GameObject projectile = Instantiate(laser, transform.position + new Vector3(0f, 0f, 0.5f), Quaternion.identity);
            projectile.transform.Rotate(new Vector3(-90f, 0f, 0f));
        }
	}
}
