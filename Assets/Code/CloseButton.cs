using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseButton: MonoBehaviour
{
    private int _level = 1;

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
