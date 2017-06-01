using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOffer : MonoBehaviour {

	public Material m_M;
	public float offsetX, offsetY,AddOffsetX,AddOffsetY;

	// Use this for initialization
	void Start () {
		//InvokeRepeating ("SetOffset", 0.1f, 0.1f);
		
	}
	
	public float scrollSpeed = 0.5F;
	public Renderer rend;

	//void Start() {
	//	rend = GetComponent<Renderer>();
	//}
	void Update() {
		SetOffset();
	}

	public void SetOffset(){
		offsetX += AddOffsetX;
		offsetY += AddOffsetY;
		m_M.SetTextureOffset ("_MainTex",new Vector2 (offsetX, offsetY));
	}
}
