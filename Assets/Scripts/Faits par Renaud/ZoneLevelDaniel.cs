using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneLevelDaniel : MonoBehaviour
{
    private LevelManager _levelManager;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            Debug.Log("Chez Daniel");
            _levelManager.LoadNextScene();
            //_levelManager.LoadAsyncScene("Daniel");
        }

    }
}
