using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public static Vector3 playerLocation;
    public float speed = 1.6f;
    private float moveX,moveY;
    private const string ENEMY_TAG = "Enemy",GROUND_TAG = "Ground";
    public bool isJump;
    Rigidbody rb;
    [HideInInspector]
    public float health=20.0f;
    [SerializeField]
    public TextMeshPro healthPlayer;
    Vector3 screenPos;
    Vector3 viewPos;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        healthPlayer.text = health.ToString();
        screenPos = Camera.main.WorldToScreenPoint(new Vector3(Screen.width,Screen.height,transform.position.z));    
    }

    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        
        transform.position += new Vector3(moveX,moveY,0f)*Time.deltaTime*speed;
        
    }
    void LateUpdate()
    {
        playerLocation = transform.position;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == ENEMY_TAG || col.gameObject.tag == GROUND_TAG)
        {
            Destroy(col.gameObject);
            ScoreManager.instance.AddPoint(5);
            Destroy(gameObject);
        }
    }
}
