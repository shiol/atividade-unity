using UnityEngine;

public class CarAlarmProximity : MonoBehaviour
{
    public AudioSource alarmSource;

    void Awake()
    {
        if (alarmSource == null)
            alarmSource = GetComponentInParent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("MainCamera")) return;
        if (alarmSource == null) return;

        if (!alarmSource.isPlaying)
            alarmSource.Play();
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("MainCamera")) return;
        if (alarmSource == null) return;

        alarmSource.Stop();
    }
}