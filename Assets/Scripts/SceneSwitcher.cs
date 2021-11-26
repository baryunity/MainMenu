// https://www.youtube.com/watch?v=PpIkrff7bKU
// https://www.youtube.com/watch?v=mGjqmK_O5jA

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchToCapsuleScene()
    {
        SceneManager.LoadScene("CapsuleScene");
    }

    public void SwitchToCubesScene()
    {
        SceneManager.LoadScene("CubePairScene");
    }
}
