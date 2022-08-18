using UnityEngine;
using TMPro;
using System.Collections;

public class ToyNPC : MonoBehaviour
{
    public float health = 13.4f;
    public float speed = 1.0f;
    [SerializeField]
    public TextMeshPro healthCard; 
    [SerializeField]
    Transform BulletHolder;
    [SerializeField]
    GameObject bullet;
    float angle=0.0f; 
    float bulletSpeed =100f;  

    void Start()
    {
        healthCard.text = health.ToString();
        StartCoroutine(Shoot());
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1f,0f,0f)*Time.deltaTime*speed;
    }
/*
    Shooting bullets at Player given below
*/
    public IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(Random.Range(2.0f,5.0f));
            GameObject b = Instantiate(bullet) as GameObject;
            b.transform.position = BulletHolder.position;
            angle = FindTheAngle();
            AddForceAtAngle(bulletSpeed,angle,b.GetComponent<Rigidbody>());
        }
    }
    void AddForceAtAngle(float force, float angle, Rigidbody BulletRB)
    {

        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * force;
        float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * force;
        
        BulletRB.AddForce(xcomponent,ycomponent,0f);
    }
    float FindTheAngle() 
    {
        Vector3 P = Player.playerLocation;
        Vector3 Q = transform.position;
        float theta = (Mathf.Atan((Q.y-P.y)/(Q.x-P.x))) *180/Mathf.PI;
        if (theta>0 && (Q.x-P.x>0))
            theta += 180;
        else if (theta<0 && (Q.y-P.y<0))
            theta += 180;
        return theta;
    }
}