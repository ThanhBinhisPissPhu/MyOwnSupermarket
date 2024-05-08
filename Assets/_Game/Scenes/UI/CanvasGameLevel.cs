using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGameLevel : UICanvas
{
    public void Setting()
    {
        UIManager.Instance.Open<CanvasSetting>();
    }

    public void Upgrade()
    {
        UIManager.Instance.Open<CanvasUpgrade>();
    }

    public void Level1()
    {
        Close(0);
        UIManager.Instance.Open<CanvasGamePlay>();
    }
}

