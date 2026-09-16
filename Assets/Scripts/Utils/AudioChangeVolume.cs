using UnityEngine;
using UnityEngine.Audio;

public class AudioChangeVolume : MonoBehaviour
{
    public AudioMixer group;
    public string floatParam = "Volume";

    public void ChangeParam(float f)
    {
        group.SetFloat(floatParam, f);
    }
}
