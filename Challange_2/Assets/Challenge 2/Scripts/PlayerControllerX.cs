using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeDelay = 1f;
    private float lastspawnTime;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > lastspawnTime + timeDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastspawnTime = Time.time;
        }
    }
}
