using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{
    public Transform Bullet;
    public Transform BulletHolder;
    public static float bulletSpeed=100f;
    float angleDegree;
    Transform BulletTrans;
    Rigidbody BulletRB;
    Vector3 fireLocation;
    bool fired=false;

    void Start()
    {
        StartCoroutine(Cooldown());
    }

    void LateUpdate()
    {
        if (fired==false & Input.GetButtonDown("Fire1")) 
        {
            fired = true;
            BulletTrans = Instantiate(Bullet, BulletHolder.position, BulletHolder.rotation);
            BulletRB = BulletTrans.GetComponent<Rigidbody>();

            fireLocation = BulletHolder.transform.position;
            //Needed for finding shooting angle
            angleDegree = FindTheAngle();
            AddForceAtAngle(bulletSpeed,angleDegree,BulletRB);
        }
        
    }
    
    IEnumerator Cooldown()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(0.7f);
            fired = false;   
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
        Vector3 P = fireLocation;
        Vector3 Q = MousePointer.GetHitLocation();
        float theta = Mathf.Atan((Q.y-P.y)/(Q.x-P.x)) *180/Mathf.PI;
        if (theta>0 && (Q.y-P.y<0))
            theta += 180;
        else if (theta<0 && (Q.y-P.y>0))
            theta += 180;
        return theta;
    }
}
