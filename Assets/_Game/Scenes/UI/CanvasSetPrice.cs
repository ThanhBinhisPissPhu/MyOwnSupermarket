using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSetPrice : UICanvas
{
    public void SetPrice()
    {
        UIManager.Instance.Open<CanvasInputPrice>();
    }
}
