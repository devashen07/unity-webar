using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeAR : MonoBehaviour
{
    #region VARIABLES 
    [SerializeField]
    public Button button;
    #endregion

    #region UNITY EVENTS
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.Invoke();
    }
    #endregion


}
