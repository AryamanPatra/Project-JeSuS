using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject gamePrefab;
    public float respawnTime = 4.0f;
    private Vector3 screenBounds;
    public static int onScreenEnemy = 0;
    
    
    void Start()
    {
        StartCoroutine(ToySpawnTimer());
    }

    private void SpawnEnemy()
    {
        if (onScreenEnemy<3)
        {
            GameObject a = Instantiate(gamePrefab) as GameObject;
            onScreenEnemy++;
            a.transform.position = new Vector3(transform.position.x,Random.Range(-2f,6.5f),transform.position.z); 
            a.GetComponent<ToyNPC>().speed = Random.Range(1.0f,4.0f);
        }
    }

    IEnumerator ToySpawnTimer()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(respawnTime);
            SpawnEnemy();
        }
    }
}
