using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform Bullet;
    public Transform BulletHolder;
    public static float bulletSpeed=100f;
    public float angleDegree = 90f;
    Transform BulletTrans;
    Rigidbody BulletRB;
    Vector3 fireLocation;
    

    void LateUpdate()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            BulletTrans = Instantiate(Bullet, BulletHolder.position, BulletHolder.rotation);
            BulletRB = BulletTrans.GetComponent<Rigidbody>();
            fireLocation = transform.position;
            // Debug.Log("FireLocation: "+fireLocation);
            angleDegree = FindTheAngle();
            AddForceAtAngle(bulletSpeed,angleDegree,BulletRB);
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
        Debug.Log(theta);
        return theta;
    }
}
