using UnityEngine;

public class BackgroundTile : MonoBehaviour {

    public Transform playerTrans;

    private Background backScript;

    private Vector3 player;

    private void Update()
    {

        if (player.y >= transform.position.y)
        {
            backScript.AddTile();
        }
}
    
    public void UpdatePlayerTransform(Vector3 trans)
    {
        Vector3 player = trans;
    }

    public void Scroll(float thrust)
    {
        transform.Translate(0f, thrust * Time.deltaTime, 0f);
    }

}
