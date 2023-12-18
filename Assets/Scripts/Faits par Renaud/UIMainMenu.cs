using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _newGame;
    [SerializeField] Button _quitGame;
    [SerializeField] Button _mainMenu;
    [SerializeField] private InfosJoueur _infosJoueur;

    private LevelManager _levelManager;
    

    // Start is called before the first frame update
    void Start()
    {
    _levelManager = LevelManager.Instance;

    _newGame.onClick.AddListener(StarNewGame);   
    _quitGame.onClick.AddListener(QuitGame);   
    _mainMenu.onClick.AddListener(MainMenu);
    }

    private void StarNewGame(){
        _infosJoueur._nbPointsTotaux = 0;
       _levelManager.LoadNewGame();
       //_levelManager.LoadAsyncScene("Nicolas");

    }
    private void QuitGame(){
        _levelManager.QuitGame();
    }
    private void MainMenu(){
        _levelManager.LoadMainMenu();
    }

}
