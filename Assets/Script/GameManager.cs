using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //private bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
        Application.OpenURL("http://google.com");
#else
        Application.Quit();
#endif
    }

    //// PauseScene
    //public void MenuScene()
    //{
    //    if(Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        if (paused)
    //        {
    //            Time.timeScale = 1;

    //            SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
    //        }
    //        else
    //        {
    //            Time.timeScale = 0;
    //        }

    //        paused = !paused;
    //    }
    //}
}
