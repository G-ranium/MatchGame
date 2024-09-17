using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent,startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    
    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsOBJ;
    private WaitForFixedUpdate wffuOBJ;

    public void Start()
    {
        wfsOBJ = new WaitForSeconds(seconds);
        wffuOBJ = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {
        startCountEvent.Invoke();
        yield return wfsOBJ;
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsOBJ;
        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
    
    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsOBJ;
            repeatUntilFalseEvent.Invoke();
        }
    }
}
