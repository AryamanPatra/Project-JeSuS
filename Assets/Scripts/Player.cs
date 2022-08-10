using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 1.6f;
    private float moveX,moveY;
    private string ENEMY_TAG = "Enemy",GROUND_TAG = "Ground";
    public bool isJump;
    Rigidbody rb;
    [HideInInspector]
    public float health=20.0f;
    [SerializeField]
    public TextMeshPro healthPlayer;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        healthPlayer.text = health.ToString();
    }

    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        
        transform.position += new Vector3(moveX,moveY,0f)*Time.deltaTime*speed;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ENEMY_TAG || col.gameObject.tag == GROUND_TAG)
        {
            Destroy(col.gameObject);
            ScoreManager.instance.AddPoint(5);
            Destroy(gameObject);
        }
    }
}
