using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve : MonoBehaviour
{
    [SerializeField] private AnimationCurve _movingCurve;
    private float currentTime;
    private float totalTime;
    // Start is called before the first frame update
    void Start()
    {
        totalTime = _movingCurve.keys[_movingCurve.keys.Length - 1].time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(transform.position.x, _movingCurve.Evaluate(currentTime), transform.position.z);
        currentTime += Time.fixedDeltaTime;
        if (currentTime >= totalTime)
        {
            currentTime = 0;
        }
    }
}
