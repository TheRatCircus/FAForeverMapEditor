﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourceObject : MonoBehaviour {

	//public ResourceBrowser Controler;
	public int InstanceId;
	public Text NameField;
	public GameObject Selected;

	public RawImage[] RawImages;

	public Text[] CustomTexts;
	public UI3DMesh MeshView;

	public void SetImages(Texture2D Tex){
		//Tex.Resize (256, 256);

		foreach (RawImage Rsrc in RawImages) {
			Rsrc.texture = Tex;
		}
	}

	public void Clicked(){

	}
	public void OnBeginDrag(){
		ResourceBrowser.DragedObject = this;
		//Cursor.SetCursor ((Texture2D)GetComponent<RawImage> ().texture, Vector2.zero, CursorMode.Auto);
		Cursor.SetCursor(ResourceBrowser.Current.GetCursorImage(), Vector2.zero, CursorMode.Auto);
	}
}
