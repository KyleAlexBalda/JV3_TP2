using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour //Si le script ne marche pas, il faut vérifier si le premier ''L'' du mot LevelManager est en majuscule
{
    [SerializeField] private GameObject _loaderCanvas;
    [SerializeField] private Image _progressBar;
    public static LevelManager Instance;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    public void Loadscene(string SceneName){
        SceneManager.LoadScene(SceneName);
    }
    public void LoadNewGame(){
        Loadscene("Level01");
    }
    public void LoadMainMenu(){
        Loadscene("MainMenu");
    }
    public void QuitGame(){
        Debug.Log("Quitter jeu");
        Application.Quit();
    }
    public void LoadNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public async void LoadAsyncScene(string SceneName){
        var scene = SceneManager.LoadSceneAsync(SceneName);

        scene.allowSceneActivation = false;

        _loaderCanvas.SetActive(true);

        do{
            await Task.Delay(100);
            _progressBar.fillAmount = scene.progress;
        }while(scene.progress < 0.9f);

        scene.allowSceneActivation = true;

        _loaderCanvas.SetActive(false);
    }
}
