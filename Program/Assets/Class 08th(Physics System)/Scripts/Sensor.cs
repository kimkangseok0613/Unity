using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Controller controller = other.GetComponent<Controller>();

        if(controller != null )
        {
            controller.Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}