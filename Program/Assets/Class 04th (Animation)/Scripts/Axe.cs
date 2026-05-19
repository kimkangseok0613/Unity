using UnityEngine;

public class Axe : MonoBehaviour
{
    public void Attack(int count)
    {
        count++;
        if(count>=10)
        {
            Debug.Log("Critical");
        }
    }

    public void Defend(int a)
    {
        Debug.Log("Defend");
    }

    public void Throw(float a)
    {
        Debug.Log("Throw");
    }
}
