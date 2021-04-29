using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCustomComponentsHandler : MonoBehaviour
{
    #region Properties
    public static CloudCustomComponentsHandler Instance = null;

    [Header("Components Reference")]
    [SerializeField] private CloudDataHandler cloudDataHandler = null;
    [SerializeField] private CloudMovementHandler cloudMovementHandler = null;
    [SerializeField] private CloudVFXHandler cloudVFXHandler = null;
    #endregion

    #region MonoBehaviour Functions
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    #endregion

    #region Getter And Setter
    public CloudDataHandler GetCloudDataHandler { get => cloudDataHandler; }

    public CloudMovementHandler GetCloudMovementHandler { get => cloudMovementHandler; }

    public CloudVFXHandler GetCloudVFXHandler { get => cloudVFXHandler; }
    #endregion
}
