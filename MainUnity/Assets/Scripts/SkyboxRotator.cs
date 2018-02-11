using UnityEngine;
using UnityEngine.UI;

public class SkyboxRotator : MonoBehaviour
{
    public float RotationPerSecond = 1;
    private bool _rotate;
    public Material[] Skyboxes;

    protected void Update()
    {
        RenderSettings.skybox = Skyboxes[resChanger.level];
        if (_rotate) RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
    }

    public void ToggleSkyboxRotation()
    {
        _rotate = !_rotate;
    }
}