using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    private float time;

	private void Update()
    {
        transform.Translate(new Vector3(0, -Time.deltaTime * speed));

        time += Time.deltaTime;
        if (time > lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
