using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefab : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    private void Start()
    {
        var go = Instantiate(prefab, transform);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}