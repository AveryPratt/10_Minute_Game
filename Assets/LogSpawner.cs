using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    public GameObject LogPrefab;
    public float Duration;
    public float width;

    private float Timer;

    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > Duration)
        {
            Timer -= Duration;
            var log = Instantiate(LogPrefab);
            log.transform.Translate(new Vector3((Random.value - .5f) * 2 * width, 0));
        }
    }
}
