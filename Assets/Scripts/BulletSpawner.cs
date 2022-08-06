using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform Bullet;
    public Transform BulletHolder;
    public static float bulletSpeed=100f;
    float angleRadian;
    Transform BulletTrans;
    Rigidbody BulletRB;
<<<<<<< HEAD
    Vector3 pointP;
=======
    Vector3 fireLocation;
>>>>>>> Trajectory
    

    void LateUpdate()
    {
        pointP = transform.position;
        angleRadian = Mathf.Atan((MousePointer.pointQ.y-pointP.y)/(MousePointer.pointQ.x-pointP.x));
        if (Input.GetButtonDown("Fire1")) 
        {
            BulletTrans = Instantiate(Bullet, BulletHolder.position, BulletHolder.rotation);
            Debug.Log("BSpawner: "+BulletTrans.transform.position);
            Debug.Log("Mouse: "+Input.mousePosition);
            BulletRB = BulletTrans.GetComponent<Rigidbody>();
<<<<<<< HEAD
            AddForceAtAngle(bulletSpeed,angleRadian);
=======
            fireLocation = transform.position;
            // Debug.Log("FireLocation: "+fireLocation);
            angleDegree = FindTheAngle();
            AddForceAtAngle(bulletSpeed,angleDegree,BulletRB);
>>>>>>> Trajectory
        }   
    }
    void AddForceAtAngle(float force, float angle)
    {
        float xcomponent = Mathf.Cos(angle) * force;
        float ycomponent = Mathf.Sin(angle) * force;
        
<<<<<<< HEAD
        BulletRB.AddForce(xcomponent, ycomponent, 0f);
=======
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
>>>>>>> Trajectory
    }
}
