using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    #region VARIABLES
    [SerializeField]
    private GameObject _loadingScreen;
    private ButtonSingleton _bs;

    [SerializeField]
    private GameObject _enviro;
    [SerializeField]
    private GameObject _help;
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
        if (_scene != Enumerations.Scenes.HomeScreen)
        {
            _enviro.SetActive(false);
            _help.SetActive(true);
        }

        _loadingScreen.SetActive(false);

    }

    public IEnumerator UnloadPressedScene(Enumerations.Scenes _scene)
    {
        AsyncOperation unloadScene = SceneManager.UnloadSceneAsync((int)_scene);

        while (!unloadScene.isDone)
        {
            _loadingScreen.SetActive(true);
            _bs.ButtonPressed = false;
            yield return null;
        }


        _loadingScreen.SetActive(false);

    }
    #endregion
}
