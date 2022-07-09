using UnityEngine;
using UnityEngine.UI;

public class MousePointer : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;
    [SerializeField]
    LayerMask layerMask;
    [SerializeField]
    Image cursor;

    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit) ){
            transform.position = raycastHit.point;
        }
        cursor.transform.position += Input.mousePosition;
    }
}
