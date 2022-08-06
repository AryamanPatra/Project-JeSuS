using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform Bullet;
    public Transform BulletHolder;
    public static float bulletSpeed=100f;
    float angleRadian;
    Transform BulletTrans;
    Rigidbody BulletRB;
    Vector3 pointP;
    

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
            AddForceAtAngle(bulletSpeed,angleRadian);
        }   
    }
    void AddForceAtAngle(float force, float angle)
    {
        float xcomponent = Mathf.Cos(angle) * force;
        float ycomponent = Mathf.Sin(angle) * force;    
        BulletRB.AddForce(xcomponent, ycomponent, 0f);
    }
}
