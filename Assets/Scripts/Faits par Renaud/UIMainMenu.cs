using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _newGame;
    [SerializeField] Button _quitGame;

    private LevelManager _levelManager;
    

    // Start is called before the first frame update
    void Start()
    {
    _levelManager = LevelManager.Instance;

    _newGame.onClick.AddListener(StarNewGame);   
    _quitGame.onClick.AddListener(QuitGame);   
    }

    private void StarNewGame(){
       // _levelManager.LoadNewGame();
       _levelManager.LoadAsyncScene("Nicolas");
    }
    private void QuitGame(){
        _levelManager.QuitGame();
    }
}
