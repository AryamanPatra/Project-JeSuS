using UnityEngine;

public class DeSpawn : MonoBehaviour
{
    
    void OnTriggerEnter(Collider cold)
    {
        Destroy(cold.gameObject);
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
