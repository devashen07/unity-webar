using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebAR : BaseState
{

    #region VARABLES
    private WebSM _sm;
    private ButtonSingleton _bs;
    #endregion

    #region INITIALIZE
    public WebAR(WebSM stateMachine) : base("WebAR", stateMachine)
    {
        _sm = stateMachine;
    }
    #endregion

    #region STATE METHODS
    public override void Enter()
    {
        base.Enter();
        _bs = ButtonSingleton.Instance;
        _bs.ButtonPressed = false; 
        _sm.AddScene(Enumerations.Scenes.WebAR);

    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        if (_bs.ButtonPressed)
        {
            _sm.ChangeState(_sm.homeState);

        }

    }

    public override void Exit()
    {
        base.Exit();

        _sm.RemoveScene(Enumerations.Scenes.WebAR);

    }
    #endregion


}
