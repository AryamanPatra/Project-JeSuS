using UnityEngine;

public class MousePointer : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;
    [SerializeField]
    LayerMask layerMask;

    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit) ){
            transform.position = raycastHit.point;
        }
    }
}
