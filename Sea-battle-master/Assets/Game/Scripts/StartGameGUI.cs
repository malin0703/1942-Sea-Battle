using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class StartGameGUI : MonoBehaviour
{

    public GameManager Manager;
    public GUISkin Skin;
    public float Widht = 200.0f, Height = 100.0f;
	public GUIStyle m_GUIStyle;
	public bool m_ButtonIsOn = true;

    void Awake()
    {
        //enabled = false;
    }

    void OnGUI()
	{
		if (Manager.GameStatus != EGameStatus.BuildingMode) {
			m_ButtonIsOn = false;
		} 
            

		if (Skin != null) {
			GUI.skin = Skin;
			m_GUIStyle = GUI.skin.button;
			m_GUIStyle.fixedHeight = 60;
			m_GUIStyle.fontSize = 30;
		}

		if (m_ButtonIsOn) {
			var centeredRect = new Rect (((Screen.width - Widht) / 2) - 50, (Screen.height - Height) - 30, 350, 100);

			GUILayout.BeginArea (centeredRect, GUI.skin.box);
			{
				if (GUILayout.Button ("Search Your Emery", GUI.skin.button)) {
					Manager.OnStartSearchButtonDown ();
				}
			}
			GUILayout.EndArea ();

			var SetRotation = new Rect (0.0f, (Screen.height - Height) - 30, (Widht / 1.5f) + 50, 100);

			GUILayout.BeginArea (SetRotation, GUI.skin.box);
			{
				if (GUILayout.Button ("Rotation", GUI.skin.button)) {
					Manager.SetReturn ();
				}
			}

			GUILayout.EndArea ();

		}

		var Setreturn = new Rect ((Screen.width - Widht / 2) - 100, (Screen.height - Height) - 30, Widht, 100);

		GUILayout.BeginArea (Setreturn, GUI.skin.box);
		{
			if (GUILayout.Button ("Return", GUI.skin.button)) {
				SceneManager.LoadScene (0, LoadSceneMode.Single); 
			}
		}
	
		GUILayout.EndArea ();

    }
}
