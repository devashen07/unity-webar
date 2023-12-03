using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeAR : MonoBehaviour
{
    #region VARIABLES
    private ButtonSingleton _bs;
    #endregion

    #region UNITY EVENTS
    public void Start()
    {
        _bs = ButtonSingleton.Instance;
    }
    #endregion
    #region PUBLIC API
    public void ButtonClickBack()
    {
        _bs.ButtonPressed = true; 
    }
    #endregion

}
