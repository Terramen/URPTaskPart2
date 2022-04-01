using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFall : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FallAnimation());
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    private IEnumerator FallAnimation()
    {
        while (true)
        {
            GameObject go = Instantiate(_prefab);
            yield return new WaitForSeconds(5f);
            Destroy(go, 5f);
        }
    }
}
