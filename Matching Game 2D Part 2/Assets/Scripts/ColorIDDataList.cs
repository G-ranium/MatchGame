using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;
    public ColorID currentColor;
    
    private int num;
    private int oldNum;

    public void SetCurrentColorRandomly()
    {
        num = Random.Range(0, colorIDList.Count);
        while (oldNum == num)
        {
            num = Random.Range(0, colorIDList.Count);
        }
        currentColor = colorIDList[num];
        oldNum = num;
    }
}
