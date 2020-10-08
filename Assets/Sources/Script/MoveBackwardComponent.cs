using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwardComponent : MonoBehaviour
{

    private float forceInitiale = 2;

    private float speedUp = 1;
    public float maxSpeedUp = 3;

    void Update()
    {
        if(speedUp < maxSpeedUp)
        {
            speedUp += Time.deltaTime;
        }
        transform.Translate(Vector3.up * ((forceInitiale*speedUp) * Time.deltaTime), Space.Self);
    }
}
