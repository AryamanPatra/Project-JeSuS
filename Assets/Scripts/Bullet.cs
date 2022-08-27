using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    const float DAMAGE = 5f;
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy"){
            ToyNPC hit = col.gameObject.GetComponent<ToyNPC>();
            hit.health -= DAMAGE;
            switch (hit.health)
            {
                case 5:
                    hit.healthCard.text = "-";
                    hit.healthCard.color = Color.red; 
                    break;
            }
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
        yield return new WaitForSecondsRealtime(4);
        Destroy(gameObject);
    }
}
