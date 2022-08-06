using UnityEngine;
using UnityEngine.UI;

public class MousePointer : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;
    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
    Image cursor;
    private static Vector3 hitLocation;

    void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue , layerMask) ){
            transform.position = raycastHit.point;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            hitLocation = transform.position;
            // Debug.Log("HitLocation: "+transform.position);
        }
        cursor.transform.position = Input.mousePosition; // For Game Cursor Movement
    }

    public static Vector3 GetHitLocation()
    {
        return hitLocation;
    }
}
