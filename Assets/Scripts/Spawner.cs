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
            a.transform.position = new Vector3(17.1f,Random.Range(1,6),1.828483f); 
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
