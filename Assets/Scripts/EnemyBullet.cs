using System.Collections;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    const float DAMAGE = 5.0f;

    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void OnTriggerEnter(Collider cold)
    {
        if (cold.gameObject.tag=="Player")
        {
            Player hit = cold.gameObject.GetComponent<Player>();
            hit.health -= DAMAGE;
            hit.healthPlayer.text = hit.health.ToString();
            if (hit.health<=0)
                Destroy(cold.gameObject);
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyBullet()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(4);
            Destroy(gameObject);
        }
    }
}
