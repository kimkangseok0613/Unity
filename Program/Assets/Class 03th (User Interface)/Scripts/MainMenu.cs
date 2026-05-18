using Unity.VisualScripting;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void NewGame() // New Game Button
    {
        Debug.Log("New game");
    }

    public void Continue() // Load Game Button
    {
        Debug.Log("Continue");
    }

    public void ShowGameAchievements() // Achievements Button
    {
        Debug.Log("Achievements");
    }

    public void Options() // Options Button
    {
        Debug.Log("Options");
    }

    public void Quit() // Quit Game Button
    {
        Debug.Log("Quit");
    }
}
