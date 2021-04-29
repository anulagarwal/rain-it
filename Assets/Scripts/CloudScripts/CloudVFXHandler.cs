using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudVFXHandler : MonoBehaviour
{
    #region Properties
    [Header("Component Reference")]
    [SerializeField] private ParticleSystem waterRain = null;
    [SerializeField] private ParticleSystem oilRain = null;
    [SerializeField] private ParticleSystem thunder = null;
    [SerializeField] private ParticleSystem snowfall = null;
    [SerializeField] private ParticleSystem tornado = null;
    #endregion

    #region Public Core Functions
    public void PlayVFX(CloudVFXType type)
    {
        switch (type)
        {
            case CloudVFXType.WaterRain:
                waterRain.Play();
                break;
            case CloudVFXType.OilRain:
                oilRain.Play();
                break;
            case CloudVFXType.Thunder:
                thunder.Play();
                break;
            case CloudVFXType.Snowfall:
                snowfall.Play();
                break;
            case CloudVFXType.Tornado:
                tornado.Play();
                break;
        }
    }
    #endregion
}
