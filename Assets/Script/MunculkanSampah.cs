using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{
    public float jeda = 1f;
    private float timer = 0f;

    public GameObject[] obyekSampah;

    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        if (obyekSampah == null || obyekSampah.Length == 0)
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer >= jeda)
        {
            int random = Random.Range(0, obyekSampah.Length);

            if (obyekSampah[random] != null)
            {
                Instantiate(
                    obyekSampah[random],
                    transform.position,
                    transform.rotation
                );
            }

            timer = 0f;
        }
    }
}
