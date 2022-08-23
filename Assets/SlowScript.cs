using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Slow());
        }
    }

    IEnumerator Slow()
    {
        while(Time.timeScale > 0.2f)
        {
            Time.timeScale -= 0.02f;
            yield return new WaitForSecondsRealtime(0.04f);
            print(Time.timeScale);
        }

        yield return new WaitForSecondsRealtime(2f);

        while (Time.timeScale < 1f)
        {
            Time.timeScale += 0.02f;
            yield return new WaitForSecondsRealtime(0.04f);
            print(Time.timeScale);
        }
    }
}
