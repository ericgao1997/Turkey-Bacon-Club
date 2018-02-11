using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    public float RotationPerSecond = 1;
    private bool _rotate = true;
    public Material[] Skyboxes;

    protected void Update()
    {
        if (_rotate) RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
        RenderSettings.skybox = Skyboxes[resChanger.level];
    }

    public void ToggleSkyboxRotation()
    {
        _rotate = !_rotate;
    }
}