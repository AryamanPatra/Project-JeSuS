using UnityEngine;
using TMPro;

public class ToyNPC : MonoBehaviour
{
    public float health = 13.4f;
    public float speed = 1.0f;
    [SerializeField]
    public TextMeshPro healthCard;    

    void Start()
    {
        healthCard.text = health.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1f,0f,0f)*Time.deltaTime*speed;
    }
}
