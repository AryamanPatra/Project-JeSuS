using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.6f;
    private float moveX,moveY;
    private string ENEMY_TAG = "Enemy",GROUND_TAG = "Ground";
    public bool isJump;
    Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        
        transform.position += new Vector3(moveX,moveY,0f)*Time.deltaTime*speed;
        // transform.position += new Vector3(0f,moveY,0f)*Time.deltaTime*speed;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ENEMY_TAG || col.gameObject.tag == GROUND_TAG)
            Destroy(gameObject);
    }
}
