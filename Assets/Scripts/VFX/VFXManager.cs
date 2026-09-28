using UnityEngine;
using Ebac.Core.Singleton;
using System.Collections.Generic;

public class VFXManager : Singleton<VFXManager>
{

    public enum VFXType
    {
        Fireflies,
        vfx2
    }

    public List<VFXManagerSetup> vfxSetup;

    public void PlayVFX(VFXType vfxType, Vector3 position)
    {
        foreach (var setup in vfxSetup)
        {
            if (setup.vfxType == vfxType)
            {
                GameObject vfx = Instantiate(setup.vfxPrefab, position, Quaternion.identity);
                Destroy(vfx, setup.duration);
                break;
            }
        }
    }
}

[System.Serializable]
public class VFXManagerSetup
{
    public VFXManager.VFXType vfxType;
    public GameObject vfxPrefab;
    public float duration;
}
