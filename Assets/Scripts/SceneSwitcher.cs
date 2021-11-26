// https://www.youtube.com/watch?v=PpIkrff7bKU
// https://www.youtube.com/watch?v=mGjqmK_O5jA

using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitcher : MonoBehaviour
{
    public void Start()
    {
        print("2021 11 26 - 11:02");
    }

    public void SwitchToCapsuleScene()
    {
        SceneManager.LoadScene("CapsuleScene");
    }

    public void SwitchToCubesScene()
    {
        SceneManager.LoadScene("CubePairScene");
    }
}
