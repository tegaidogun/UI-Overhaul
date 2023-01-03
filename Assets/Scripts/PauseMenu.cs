using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){

            if (GameisPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    public void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void MainMenu()
    {
       Time.timeScale = 1f;
       Debug.Log("Maenu it is");
       SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
       Debug.Log("Quitters you are");
       Application.Quit();
    }
    
}
