using UnityEngine;

public class DeSpawn : MonoBehaviour
{
    
    void OnTriggerEnter(Collider cold)
    {
        if (cold.tag == "Ground")
            cold.transform.position = new Vector3(17.1f, 0f, 0f);
        else
            Destroy(cold.gameObject);
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
