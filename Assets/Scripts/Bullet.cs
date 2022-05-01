using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy"){
            Destroy(col.gameObject);
            Destroy(gameObject);
            Debug.Log("Kill");
        }
    }
    
    IEnumerator DestroyBullet()
    {
        yield return new WaitForSecondsRealtime(7);
        Destroy(gameObject);
        Debug.Log("Missed");
    }
}
