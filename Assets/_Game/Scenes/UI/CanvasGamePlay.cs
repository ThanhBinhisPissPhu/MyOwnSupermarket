using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGamePlay : UICanvas
{
    public void Setting()
    {
        UIManager.Instance.Open<CanvasSetting>();
    }

    public void News()
    {
        UIManager.Instance.Open<CanvasNews>();
    }

    public void StageInfo()
    {
        UIManager.Instance.Open<CanvasStageInfo>();
    }

    public void ImportStuff()
    {
        UIManager.Instance.Open<CanvasImportStuff>();
    }

    public void SetPrice()
    {
        UIManager.Instance.Open<CanvasSetPrice>();
    }
}

