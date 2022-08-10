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
            hit.healthCard.text = hit.health.ToString();
            if (hit.health <= 0f)
            {
                Destroy(col.gameObject);
                ScoreManager.instance.AddPoint(5);
                Spawner.onScreenEnemy--;
            }
            Destroy(gameObject);
        }
    }
    
    IEnumerator DestroyBullet()
    {
        yield return new WaitForSecondsRealtime(7);
        Destroy(gameObject);
    }
}
