using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num = 0;
    private int oldNum = 1;
    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3DList)
        {
            Instantiate(prefab,t.value,Quaternion.identity);
        }
    }
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab,obj.vector3DList[num].value,Quaternion.identity);
        num++;
        if (num == obj.vector3DList.Count)
        {
            num = 0;
        }
    }
    public void CreateInstanceFromListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DList.Count);
        //the following loop gives the spawn positions more variety
        while (oldNum == num)
        {
            num = Random.Range(0, obj.vector3DList.Count);
        }
        Instantiate(prefab,obj.vector3DList[num].value,Quaternion.identity);
        // oldNum is a way to keep track of previous prefab instance
        oldNum = num;
    }
}
