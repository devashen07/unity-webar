using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    #region VARIABLES 
    [SerializeField]
    private List<GameObject> listOfModels;

    private int index = 0;
    #endregion

    #region Public API
    public void OnClickNext()
    {
        listOfModels[index].SetActive(false); 
        if (index < listOfModels.Count - 1)
        {
            index += 1; 
        }
        else
        {
            index = 0;  
        }

        listOfModels[index].SetActive(true);
        
    }

    public void OnClickPrevious()
    {
        listOfModels[index].SetActive(false);
        if (index != 0)
        {
            index -= 1;
        }
        else
        {
            index = listOfModels.Count - 1;
        }

        listOfModels[index].SetActive(true);
    }
    #endregion

    #region UNITY EVENTS

    public void Start()
    {
        index = 0; 
    }
    #endregion
}
