// https://www.youtube.com/watch?v=PpIkrff7bKU
// https://www.youtube.com/watch?v=mGjqmK_O5jA

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchToCapsuleScene()
    {
        print("SceneSwitcher: switch to capsule");  //FOO
        SceneManager.LoadScene(1);
    }

    public void SwitchToCubesScene()
    {
        print("SceneSwitcher: switch to cubes");  //FOO
        SceneManager.LoadScene(2);
    }
}
