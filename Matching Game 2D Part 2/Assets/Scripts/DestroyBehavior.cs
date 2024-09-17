using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wfsOBJ;
    IEnumerator Start()
    {
        wfsOBJ = new WaitForSeconds(seconds);
        yield return wfsOBJ;
        Destroy(gameObject);
    }
}
