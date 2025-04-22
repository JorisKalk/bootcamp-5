using UnityEngine;
using UnityEngine.SceneManagement;  // Import the SceneManager namespace

public class SceneReloader : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the Enter key (or Return) is pressed
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Reload the current scene
            ReloadScene();
        }
    }

    // Method to reload the current scene
    void ReloadScene()
    {
        // Get the name of the currently loaded scene
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Reload the scene
        SceneManager.LoadScene(currentSceneName);
    }
}
