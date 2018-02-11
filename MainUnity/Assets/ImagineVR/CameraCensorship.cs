using UnityEngine;
using System.Collections;

public class CameraCensorship : MonoBehaviour {

    private int timeToFade = 5;
    private float startCellSize = 0.0001f;
    private float finalCellSize = 0.1f;

    private bool fadeToggle = true;
    private Vector4 pixelVector;

    public enum FADE_TYPE
    {
        MOSAIC,
        BLACK
    }
    public FADE_TYPE fadeType = FADE_TYPE.MOSAIC;

    // Update is called once per frame
    public bool test = false;
	void Update () {
	    if (test)
        {
            Fade();
            test = false;
        }
	}

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<Renderer>().material.name.StartsWith("Pixelation"))
        {
            pixelVector = collision.gameObject.GetComponent<Renderer>().material.GetVector("_CellSize");
            Fade();
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.GetComponent<Renderer>().material.name.StartsWith("Pixelation"))
        {
            Fade();
            collision.gameObject.GetComponent<Renderer>().material.SetVector("_CellSize", pixelVector);
        }
    }


    public void Fade()
    {
        switch (fadeType)
        {
            case FADE_TYPE.BLACK:
                FadeBlackToggle();
                break;
            case FADE_TYPE.MOSAIC:
            default:
                FadeMosaicToggle();
                break;
        }
    }

    public void FadeMosaicToggle()
    {
        FadeMosaic(fadeToggle);
        fadeToggle = !fadeToggle;
    }

    public void FadeMosaic(bool isFadeOut)
    {
        StartCoroutine(_FadeMosaic(isFadeOut));
    }

    IEnumerator _FadeMosaic(bool isFadeOut)
    {
        Renderer r = gameObject.GetComponent<Renderer>();
        r.material = Resources.Load("Pixelation_Fader", typeof(Material)) as Material;
        float fadeInitCellSize = isFadeOut ? startCellSize : finalCellSize;
        float fadeEndCellSize = isFadeOut ? finalCellSize : startCellSize;
        r.material.SetVector("_CellSize", new Vector4(fadeInitCellSize, fadeInitCellSize, 0f, 0f));
        r.enabled = true;

        for (int i=0; i<timeToFade; i++)
        {
            float cellSize = Mathf.Lerp(fadeInitCellSize, fadeEndCellSize, (float)i / (float)timeToFade);
            r.material.SetVector("_CellSize", new Vector4(cellSize, cellSize, 0f, 0f));
            yield return null;
        }
        r.material.SetVector("_CellSize", new Vector4(fadeEndCellSize, fadeEndCellSize, 0f, 0f));
        if (!isFadeOut)
        {
            r.enabled = false;
        }
    }

    public void FadeBlackToggle()
    {
        FadeBlack(fadeToggle);
        fadeToggle = !fadeToggle;
    }

    public void FadeBlack(bool isFadeOut)
    {
        StartCoroutine(_FadeBlack(isFadeOut));
    }

    IEnumerator _FadeBlack(bool isFadeOut)
    {
        Renderer r = gameObject.GetComponent<Renderer>();
        r.material = Resources.Load("BlackFade", typeof(Material)) as Material;
        float initFadeAlpha = isFadeOut ? 0f : 1f;
        float endFadeAlpha = isFadeOut ? 1f : 0f;
        r.material.color = new Color(0f, 0f, 0f, initFadeAlpha);
        r.enabled = true;

        for (int i = 0; i < timeToFade; i++)
        {
            float alpha = Mathf.Lerp(initFadeAlpha, endFadeAlpha, (float)i / (float)timeToFade);
            r.material.color = new Color(0f, 0f, 0f, alpha);
            yield return null;
        }
        r.material.color = new Color(0f, 0f, 0f, endFadeAlpha);
        if (!isFadeOut)
        {
            r.enabled = false;
        }
    }
}
