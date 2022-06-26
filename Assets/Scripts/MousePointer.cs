using UnityEngine;

public class MousePointer : MonoBehaviour
{
    public static Vector3 pointQ;
    [SerializeField] Camera mainCamera;
    void Update()
    {
        transform.position = Input.mousePosition;
        Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        pointQ = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
