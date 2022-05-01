using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject gamePrefab;
    public float respawnTime = 2.0f;
    private Vector3 screenBounds;
    
    
    void Start()
    {
        StartCoroutine(ToySpawnTimer());
    }

    private void SpawnEnemy()
    {
        GameObject a = Instantiate(gamePrefab) as GameObject;
        a.transform.position = new Vector3(17.1f,Random.Range(1,4),1.828483f); 
        a.GetComponent<ToyNPC>().speed = Random.Range(1.0f,4.0f);
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
