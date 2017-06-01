using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EntryMenuGUI : MonoBehaviour
{


    public GUISkin Skin;
    public float Widht = 200.0f, Height = 100.0f;
	public GUIStyle m_GUIStyle;
	public bool m_Play, m_ExitGame, m_Next;
	public Image m_ChangeImage;
	public int index;
	public Sprite m_BGImage1, m_BGImage2;


	public void Check(){
		if(index == 0){
			m_ChangeImage.sprite = m_BGImage1;
			index = 1;
			m_Play = false;
			m_ExitGame = false;
			m_Next = true;
		}else if(index == 1){
			m_ChangeImage.sprite = m_BGImage2;
			index = 2;
		}else if(index == 2){
			index = 2;
			m_Next = false;
			SceneManager.LoadScene (1, LoadSceneMode.Single); 

		}
	}


    void OnGUI()
    {
        if (Skin != null)
        {
            GUI.skin = Skin;
			m_GUIStyle = GUI.skin.button;
			m_GUIStyle.fixedHeight = 100;
			m_GUIStyle.fontSize = 40;
        }
		var centeredRect2 = new Rect((Screen.width - Widht) / 2+400, (Screen.height - Height) / 2, Widht, Height);
       
		if (m_Next) {
			GUILayout.BeginArea (centeredRect2, GUI.skin.box);
			{
			
				GUILayout.Label ("Click NEXT", GUI.skin.label);
				if (GUILayout.Button ("NEXT", m_GUIStyle)) {
					Check ();   
				}
			
			}
			GUILayout.EndArea ();
		}
		var centeredRect = new Rect((Screen.width - Widht) / 2, (Screen.height - Height) / 2, Widht, Height);
		if (m_Play) {
			GUILayout.BeginArea (centeredRect, GUI.skin.box);
			{
			
				GUILayout.Label ("Battle Now", GUI.skin.label);
				if (GUILayout.Button ("Play", m_GUIStyle)) {
					Check ();  
				}
			
			}
			GUILayout.EndArea();
		}


		var Setreturn = new Rect((Screen.width - Widht) / 2, (Screen.height - Height)+100, Widht, 100);

		if (m_ExitGame) {
			GUILayout.BeginArea (Setreturn, GUI.skin.box);
			{
			
				if (GUILayout.Button ("Exit Game", GUI.skin.button)) {
					Application.Quit (); 
				}
			
			}
			GUILayout.EndArea();
		}

    }
}
