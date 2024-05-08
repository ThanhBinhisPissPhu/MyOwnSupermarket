using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSetting : UICanvas
{
    public void Home(){
        UIManager.Instance.CloseAll();
        UIManager.Instance.Open<CanvasGameMenu>();
    }
}
