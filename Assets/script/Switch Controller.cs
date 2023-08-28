using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    { 
        off,
        On,
        Blink
    }

    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public float score;

    public ScoreManager scoreManager;

    private SwitchState state;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
        }
    }
    private void set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }

    }

    private void Toggle()
    {
        if (state == SwitchState.On)
        {
            set(false);
        }
        else
        {
            set(true);
        }


    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        int BlinkTimes = times * 2;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }
        state = SwitchState.off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));

    }
}
