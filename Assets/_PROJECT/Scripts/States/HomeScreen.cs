using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Collections.ObjectModel;
using UnityEngine.UI;


public class HomeScreen : BaseState
{

    #region VARABLES
    private WebSM _sm;
    private ButtonSingleton _bs;
    #endregion

    #region INITIALIZE
    public HomeScreen(WebSM stateMachine) : base("HomeScreen", stateMachine)
    {
        _sm = stateMachine;
    }
    #endregion

    #region STATE METHODS
    public override void Enter()
    {
        base.Enter();
        _bs = ButtonSingleton.Instance;
        _sm.AddScene(Enumerations.Scenes.HomeScreen);
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        if (_bs)
        {
            _sm.ChangeState(_sm.webARState);

        }
        
    }

    public override void Exit()
    {
        base.Exit();

        _sm.RemoveScene(Enumerations.Scenes.HomeScreen);

    }
    #endregion


}
