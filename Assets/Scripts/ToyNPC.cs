using UnityEngine;

public class ToyNPC : MonoBehaviour
{
    public float health = 20.0f;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1f,0f,0f)*Time.deltaTime*speed;
    }
}
