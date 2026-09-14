using UnityEngine;

public class AudioPlayerHelper : MonoBehaviour
{
    public KeyCode keycode = KeyCode.P;
    public AudioSource audio;
     
     void Update()
     {
         if(Input.GetKeyDown(keycode))
         {
             Play();
         }    
     }

     public void Play()
     {
         if(audio != null)
         {
             audio.Play();
         }
     }
}
