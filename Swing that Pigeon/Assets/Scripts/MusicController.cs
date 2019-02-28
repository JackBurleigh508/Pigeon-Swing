using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }



    void Update()
    {

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "MenuScreen" || scene.name == "Victory" || scene.name == "Defeat")
        {
            Destroy(gameObject);
        }
    }
}
