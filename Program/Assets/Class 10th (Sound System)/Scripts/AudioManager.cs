using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Toggle toggle;
    [SerializeField] AudioSource audioSource;
    public void SetPause()
    {
        if (toggle.isOn)
        {
            audioSource.UnPause();
            Debug.Log("Playing BGM");
        }
        else
        {
            audioSource.Pause();
            Debug.Log("Sttoped BGM");
        }
    }
}