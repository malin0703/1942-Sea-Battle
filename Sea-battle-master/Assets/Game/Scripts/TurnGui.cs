using UnityEngine;
using System.Collections;

public class TurnGui : MonoBehaviour
{

    public GameManager GManager;
    public ClientRPCManager RpcHandler;

    public GUISkin Skin;
	public GUIStyle m_GUIStyle;
    public float Widht = 200.0f, Height = 100.0f;
    private string _turnMessage = "Prepare for battle!";

    void Update()
    {
        if (GManager.GameInProgress)
        {
           _turnMessage = GManager.GameStatus == EGameStatus.MyTurn ? "Your turn" : "Opponent turn";
        }
        if (GManager.GameStatus == EGameStatus.Defeat)
        {
            _turnMessage = "You are lose :/";
        }
        if (GManager.GameStatus == EGameStatus.Win)
        {
            _turnMessage = "You are win :)";
        }
    }

    void OnGUI()
    {
        if (Skin != null)
        {
            GUI.skin = Skin;
			m_GUIStyle = GUI.skin.label;
			m_GUIStyle.fixedHeight = 50;
			m_GUIStyle.fontSize = 30;
        }

		var centeredRect = new Rect((Screen.width - Widht) / 2, 2.5f, 400, 80);
        var leftRect = new Rect(0.0f, 2.5f, 250, 80);
		var rightRect = new Rect((Screen.width - Widht/2), 2.5f, Widht/2, 80);

        GUILayout.BeginArea(centeredRect, GUI.skin.box);
        {
			GUILayout.Label(_turnMessage, m_GUIStyle);
        }
        GUILayout.EndArea();

        GUILayout.BeginArea(leftRect, GUI.skin.box);
        {
			GUILayout.Label(("EnemyHP: " + GManager.EnemyHP), m_GUIStyle);
        }
        GUILayout.EndArea();

        GUILayout.BeginArea(rightRect, GUI.skin.box);
        {
			GUILayout.Label("HP: " + GManager.HP, m_GUIStyle);
        }
        GUILayout.EndArea();


    }
}
