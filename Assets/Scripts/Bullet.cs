using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    const float DAMAGE = 6.7f;
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy"){
            ToyNPC hit = col.gameObject.GetComponent<ToyNPC>();
            hit.health -= DAMAGE;
            if (hit.health <= 0f)
                Destroy(col.gameObject);
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
    }
    
    IEnumerator DestroyBullet()
    {
        yield return new WaitForSecondsRealtime(7);
        Destroy(gameObject);
    }
}
