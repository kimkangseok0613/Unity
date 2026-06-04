using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject elemental;
    [SerializeField] float offset = 1.5f;
    [SerializeField] List<GameObject> list;
    [SerializeField] int count;
    [SerializeField] WaitForSeconds waitForSeconds = new WaitForSeconds(5f);


    void Start()
    {
        for (int i=0; i<5; i++)
        {
            GameObject clone = Instantiate(elemental, transform);

            clone.transform.position = new Vector3(-3 + (offset * i), 0, 0);

            clone.SetActive(false);

            list.Add(clone);
        }
        StartCoroutine(Coroutine());
    }
    
    IEnumerator Coroutine()
    {
        while (count < list.Count)
        {
            list[count++].SetActive(true);

            yield return waitForSeconds;
        }
        Debug.Log("End");
    }
}
