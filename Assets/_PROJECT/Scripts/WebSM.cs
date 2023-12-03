using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WebSM : StateMachine
{
    #region STATE VARIABLES 
    [HideInInspector]
    public HomeScreen homeState;
    [HideInInspector]
    public WebAR webARState;
    [SerializeField]
    public LoadNewScene loadNewScene;

    #endregion

    #region UNITY EVENTS
    private void Awake()
    {
        homeState = new HomeScreen(this);
        webARState = new WebAR(this);
    }
    #endregion

    #region START STATE INITIALIZATION
    protected override BaseState GetInitialState()
    {
        return homeState;
    }
    #endregion

    #region PUBLIC API 
    public void AddScene(Enumerations.Scenes _sceneName)
    {
        StartCoroutine(loadNewScene.LoadPressedScene(_sceneName));
    }

    public void RemoveScene(Enumerations.Scenes _sceneName)
    {
        StartCoroutine(loadNewScene.UnloadPressedScene(_sceneName));
    }


    #endregion

}
