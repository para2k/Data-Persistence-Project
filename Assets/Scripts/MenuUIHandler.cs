using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameText;

    public void StartMainScene()
    {
        string sanitizedText = nameText.text
        .Replace("\u200B", "") // Remove zero-width spaces
        .Trim(); // Trim whitespace
        if (string.IsNullOrWhiteSpace(sanitizedText))
        {
            Debug.Log("Empty");
            nameText.text = "Player";
        }

        PlayerManager.Instance.playerName = nameText.text;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
                Application.Quit();
#endif
    }
}
