using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSingleton : Singleton<ButtonSingleton>
{
    public bool ButtonPressed { get; set; }
}
