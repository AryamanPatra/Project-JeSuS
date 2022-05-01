using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform Bullet;
    public Transform BulletHolder;
    public float bulletSpeed=100f;
    public float angleDegree = 90f;
    Transform BulletTrans;
    Rigidbody BulletRB;

    

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            BulletTrans = Instantiate(Bullet, BulletHolder.position, BulletHolder.rotation);
            BulletRB = BulletTrans.GetComponent<Rigidbody>();
            AddForceAtAngle(bulletSpeed,angleDegree,BulletRB);
        }   
    }
    public void AddForceAtAngle(float force, float angle, Rigidbody BulletRB)
    {
        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * force;
        float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * force;
        
        BulletRB.AddForce(ycomponent, -45f, xcomponent);
    }
}
