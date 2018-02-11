/// <summary>
/// Editor script to apply pixelation (censorship blurring)
/// to an object called "PixelatedObject" found anywhere in the scene
/// or to the selected objects
/// </summary>

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Linq;

public class ApplyPixelation : ScriptableWizard
{
	public bool findPixelatedObject = true;
	public bool applyToSelected = true;
    public bool useBlackfade = false;
	private Material pixelMat;

	[MenuItem("Tools/ApplyPixelation")]
	static void CreateWizard ()
	{
		ScriptableWizard.DisplayWizard<ApplyPixelation>("Apply Pixelation", "Apply");
		
	}
	
	void OnEnable()
	{
		// Editor/Resources folder must contain Pixelation material and Pixel Shader!
		pixelMat = Resources.Load ("Pixelation", typeof(Material)) as Material;

	}

	void OnWizardUpdate()
	{
		helpString = "Apply the Pixelation/censored material to the\nGameObject called \"PixelatedObject\" and/or the\nselected objects. When useBlackFade is selected, camera will fade to black when too close to censored object. Otherwise, it will mosaic/pixelate.";
	}
	
	void OnWizardCreate ()
	{
		try
		{

			AssetDatabase.StartAssetEditing();

			if (findPixelatedObject)
			{
				Renderer[] renderers = GameObject.FindObjectsOfType (typeof(Renderer)) as Renderer[];
				foreach (var renderer in renderers) 
				{
					if (renderer.name == "PixelatedObject")
					{
						renderer.material = pixelMat;
						Debug.Log("Found: assigned " + renderer.name + " a pixelation material");
					}
				}
			}

			if (applyToSelected)
			{
				var selectedRenderers = Selection.GetFiltered(typeof(Renderer), SelectionMode.Assets).Cast<Renderer>();
				foreach(var renderer in selectedRenderers)
				{
					renderer.material = pixelMat;
                    Debug.Log("Selected: assigned " + renderer.name + " a pixelation material");
				}
			}

            float nearClippingDistance = Camera.main.nearClipPlane;
            GameObject mosaicQuad = (GameObject)Instantiate(Resources.Load("MosaicQuad", typeof(GameObject)) as GameObject);
            mosaicQuad.transform.SetParent(Camera.main.transform);
            mosaicQuad.transform.localPosition = new Vector3(0f, 0f, nearClippingDistance + 0.000001f);
            mosaicQuad.GetComponent<Renderer>().enabled = false;
            if (useBlackfade)
            {
                mosaicQuad.GetComponent<CameraCensorship>().fadeType = CameraCensorship.FADE_TYPE.BLACK;
            }
		}
		finally
		{
			AssetDatabase.StopAssetEditing();
			AssetDatabase.SaveAssets();
		}
	}
}