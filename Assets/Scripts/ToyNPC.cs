using UnityEngine;

public class ToyNPC : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1f,0f,0f)*Time.deltaTime*speed;
    }
}
