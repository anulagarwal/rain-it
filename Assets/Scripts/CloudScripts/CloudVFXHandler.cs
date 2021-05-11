using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudVFXHandler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private CloudVFXType cloudActiveVFX = CloudVFXType.WaterRain;

    [Header("Component Reference")]
    [SerializeField] private ParticleSystem waterRain = null;
    [SerializeField] private ParticleSystem oilRain = null;
    [SerializeField] private ParticleSystem thunder = null;
    [SerializeField] private ParticleSystem snowfall = null;
    [SerializeField] private ParticleSystem tornado = null;

    private CloudDataHandler cloudDataHandler = null;
    private bool vfxActive = false;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        cloudDataHandler = CloudCustomComponentsHandler.Instance.GetCloudDataHandler;
        vfxActive = false;
    }

    private void Update()
    {
        if (!vfxActive && cloudDataHandler.CharacterObjects.Count > 0)
        {
            PlayVFX(cloudActiveVFX, true);
            vfxActive = true;
        }
        else if (vfxActive && cloudDataHandler.CharacterObjects.Count <= 0)
        {
            PlayVFX(cloudActiveVFX, false);
            vfxActive = false;
        }
    }
    #endregion

    #region Private Core Functions
    private void PlayVFX(CloudVFXType type, bool play = false)
    {
        switch (type)
        {
            case CloudVFXType.WaterRain:
                if (waterRain.gameObject.activeSelf)
                {
                    if (play)
                    {
                        waterRain.Play();
                    }
                    else
                    {
                        waterRain.Stop();
                    }
                }
                break;
            case CloudVFXType.OilRain:
                if (oilRain.gameObject.activeSelf)
                {
                    if (play)
                    {
                        oilRain.Play();
                    }
                    else
                    {
                        oilRain.Stop();
                    }
                }
                break;
            case CloudVFXType.Thunder:
                if (thunder.gameObject.activeSelf)
                {
                    if (play)
                    {
                        thunder.Play();
                    }
                    else
                    {
                        thunder.Stop();
                    }
                }
                break;
            case CloudVFXType.Snowfall:
                if (snowfall.gameObject.activeSelf)
                {
                    if (play)
                    {
                        snowfall.Play();
                    }
                    else
                    {
                        snowfall.Stop();
                    }
                }
                break;
            case CloudVFXType.Tornado:
                if (tornado.gameObject.activeSelf)
                {
                    if (play)
                    {
                        tornado.Play();
                    }
                    else
                    {
                        tornado.Stop();
                    }
                }
                break;
        }
    }
    #endregion
}
