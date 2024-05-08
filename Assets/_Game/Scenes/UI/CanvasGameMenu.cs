using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGameMenu : UICanvas
{
    public void Play()
    {
        Close(0);
        UIManager.Instance.Open<CanvasGameLevel>();
    }

    public void Setting()
    {
        UIManager.Instance.Open<CanvasSetting>();
    }
}
