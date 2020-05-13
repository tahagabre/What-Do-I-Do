using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterControl : MonoBehaviour
{
    AudioHighPassFilter highPass;
    AudioLowPassFilter lowPass;
    Camera camera;

    void Awake()
    {
        highPass = GetComponent<AudioHighPassFilter>();
        lowPass = GetComponent<AudioLowPassFilter>();
        camera = FindObjectOfType<Camera>();

        highPass.cutoffFrequency = 900;
        lowPass.cutoffFrequency = 900;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, camera.transform.position);
        highPass.cutoffFrequency = distance * 10;
        lowPass.cutoffFrequency = distance * 10;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            highPass.enabled = false;
            lowPass.enabled = false;
        }
    }
}
