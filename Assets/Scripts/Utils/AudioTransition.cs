using UnityEngine;
using UnityEngine.Audio;

public class AudioTransition : MonoBehaviour
{
    public AudioMixerSnapshot snapshot;
    public float transitionTime = 0.1f;

    public void TransitionToSnapshot()
    {
        snapshot.TransitionTo(transitionTime);
    }
}
