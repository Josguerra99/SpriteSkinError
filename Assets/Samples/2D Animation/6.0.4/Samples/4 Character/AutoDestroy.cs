using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float t = 1;
    private WaitForSeconds wait;

    private void Awake()
    {
        wait = new WaitForSeconds(t);
        StartCoroutine(Destroy());
    }

    public IEnumerator Destroy()
    {
        yield return wait;
        Destroy(gameObject);
    }
}