using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField]
    Transform player;


    void OnTriggerExit(Collider cold)
    {
        if (cold.gameObject.tag=="Player")
           cold.transform.position += new Vector3(-Player.instance.moveX,-Player.instance.moveY,0);
        // if (cold.gameObject.tag == "Enemy")
        // {
        //     ToyNPC enemy = cold.gameObject.GetComponent<ToyNPC>();
        //     StopCoroutine(enemy.Shoot());
        // }
    }
    // void OnTriggerEnter(Collider cold)
    // {
    //     if (cold.gameObject.tag == "Enemy")
    //     {
    //         ToyNPC enemy = cold.gameObject.GetComponent<ToyNPC>();
    //         StartCoroutine(enemy.Shoot());
    //     }
    // }
}
