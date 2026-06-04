using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Ray ray;
    void Update()
    {

    }
    private void OnDrawGizmos()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Gizmos.DrawRay(ray.origin,ray.direction * 100);
    }
}
