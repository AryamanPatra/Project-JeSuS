using System.Collections;
using UnityEngine;

public class TerrainPlane : MonoBehaviour
{
    public float speed = 1.3f;
    Rigidbody rb;
    
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        transform.position += new Vector3(-1f,0f,0f)*Time.deltaTime*speed;
        if (transform.position.x == -13.80)
            GetComponent<Collider>().isTrigger = true;
    }
}
