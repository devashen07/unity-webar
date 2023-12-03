using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    #region VARIABLES
    [SerializeField]
    private GameObject _loadingScreen;
    [SerializeField]
    private GameObject _enviro; 
    private ButtonSingleton _bs;
    #endregion

    #region PUBLIC API 

    public void Start()
    {
        _bs = ButtonSingleton.Instance;
    }
    public IEnumerator LoadPressedScene(Enumerations.Scenes _scene)
    {
        AsyncOperation loadScene;


        loadScene = SceneManager.LoadSceneAsync((int)_scene, LoadSceneMode.Additive);

        while (!loadScene.isDone)
        {
            _enviro.SetActive(true);
            _loadingScreen.SetActive(true);
            yield return null;
        }

        _loadingScreen.SetActive(false);
        _enviro.SetActive(false);

    }

    public IEnumerator UnloadPressedScene(Enumerations.Scenes _scene)
    {
        AsyncOperation unloadScene = SceneManager.UnloadSceneAsync((int)_scene);

        while (!unloadScene.isDone)
        {
            _enviro.SetActive(true);
            _loadingScreen.SetActive(true);
            _bs.ButtonPressed = false;
            yield return null;
        }

        
        _loadingScreen.SetActive(false);
        _enviro.SetActive(false);

    }
    #endregion
}
