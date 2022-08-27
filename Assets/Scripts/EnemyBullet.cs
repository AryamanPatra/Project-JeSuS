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
            switch (hit.health)
            {
                case 15:
                    hit.healthPlayer.text = "---"; 
                    hit.healthPlayer.color=Color.yellow; 
                    break;
                case 10:
                    hit.healthPlayer.text = "--"; break;
                case 5:
                    hit.healthPlayer.text = "-"; 
                    hit.healthPlayer.color=Color.red;
                    break;
            }
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
