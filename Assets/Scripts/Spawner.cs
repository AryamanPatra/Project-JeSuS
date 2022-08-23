using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public float respawnTime = 4.0f;
    private Vector3 screenBounds;
    public static int onScreenEnemy = 0;
    [SerializeField]
    GameObject[] cArray;
    float size;
    float rotate;
    
    void Start()
    {
        StartCoroutine(ToySpawnTimer());
        StartCoroutine(SpawnCloudTimer());
    }
    private void SpawnEnemy()
    {
        if (onScreenEnemy<3)
        {
            GameObject a = Instantiate(enemy) as GameObject;
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

    IEnumerator SpawnCloudTimer()
    {
        while(true)
        {
            float j = Random.Range(100,800);    
            yield return new WaitForSecondsRealtime(j*0.0005f);
            SpawnCloud(j);
        }
    }
    private void SpawnCloud(float j)
    {
        int i = (int)Random.Range(0,6); 
        GameObject c = Instantiate(cArray[i]) as GameObject;
        c.transform.position = new Vector3(transform.position.x+800,-59.5f,j);
        size = Random.Range(0.5f,1.7f);
        c.transform.localScale = new Vector3(size,size,size);
        c.transform.Rotate(0,Random.Range(0,15),0);
    }
}
