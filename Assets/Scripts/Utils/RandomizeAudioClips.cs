using System.Collections.Generic;
using UnityEngine;

public class RandomizeAudioClips : MonoBehaviour
{
    [System.Serializable]
    public class AudioGroup
    {
        public string id;
        public List<AudioClip> clips;
        public List<AudioSource> sources;

        private int _sourceIndex = 0;

        public void PlayRandom()
        {
            if (clips == null || clips.Count == 0)
                return;

            if (sources == null || sources.Count == 0)
                return;

            if (_sourceIndex >= sources.Count)
                _sourceIndex = 0;

            AudioSource source = sources[_sourceIndex];

            source.clip = clips[Random.Range(0, clips.Count)];
            source.Play();

            _sourceIndex++;
        }
    }

    public List<AudioGroup> audioGroups;

    public void PlayRandom(string id)
    {
        AudioGroup group = audioGroups.Find(x => x.id == id);

        if (group == null)
        {
            Debug.LogWarning($"Audio group '{id}' not found.");
            return;
        }

        group.PlayRandom();
    }
}