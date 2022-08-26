using UnityEngine;

public class DeSpawn : MonoBehaviour
{
    
    void OnTriggerEnter(Collider cold)
    {
        if (cold.tag=="Enemy")
            Spawner.onScreenEnemy--;
        Destroy(cold.gameObject);
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}