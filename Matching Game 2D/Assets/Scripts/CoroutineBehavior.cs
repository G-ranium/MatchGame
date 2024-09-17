using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent repeatEvent;
    
    public int counterNum = 3;
    public float seconds = 3.0f;
    private WaitForSeconds wfsOBJ;
    private WaitForFixedUpdate wffuOBJ;
    IEnumerator Start()
    {
        wfsOBJ = new WaitForSeconds(seconds);
        wffuOBJ = new WaitForFixedUpdate();
        Debug.Log("test");

        while (counterNum > 0)
        {
            yield return wfsOBJ;
            repeatEvent.Invoke();
            counterNum--;
        }
    }
}
