using UnityEngine;

public class Cloud : MonoBehaviour
{
    float speedFactor=0f;
    // Start is called before the first frame update
    void Start()
    {
        speedFactor = 100000*(1/transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1f,0f,0f)*Time.deltaTime*speedFactor;
        if (transform.position.x<=-1001.0f)
            Destroy(gameObject);
    }
}
