using UnityEngine;
using System.Collections;


public class StartGameGUI : MonoBehaviour
{

    public GameManager Manager;
    public GUISkin Skin;
    public float Widht = 200.0f, Height = 100.0f;

    void Awake()
    {
        //enabled = false;
    }

    void OnGUI()
    {
        if (Manager.GameStatus != EGameStatus.BuildingMode) 
            enabled = false;

        if (Skin != null)
            GUI.skin = Skin;

        var centeredRect = new Rect((Screen.width - Widht) / 2, (Screen.height - Height), Widht, Height);

        GUILayout.BeginArea(centeredRect, GUI.skin.box);
        {
			if (GUILayout.Button("開始搜索", GUI.skin.button))
            {
                Manager.OnStartSearchButtonDown();
            }
        }
		GUILayout.EndArea();

		var Setreturn = new Rect(0.0f, (Screen.height - Height), Widht/1.5f, Height);

		GUILayout.BeginArea(Setreturn, GUI.skin.box);
		{
			if (GUILayout.Button("轉向", GUI.skin.button))
			{
				Manager.SetReturn();
			}
		}

        GUILayout.EndArea();
    }
}
