using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGameEnd : UICanvas
{
    public void Back(){
        Close(0);
        UIManager.Instance.Open<CanvasGameMenu>();
    }
}
