using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField NameInput;

    void Start()
    {
        NameInput.onEndEdit.AddListener(delegate { SetPlayerName(NameInput); });
    }
    public void StartGame()
    {
        Debug.Log("Name: " + PlayerDataHandler.Instance.PlayerName.ToString());
        SceneManager.LoadScene(2);
    }

    public void SetPlayerName(TMP_InputField nameInput)
    {
        PlayerDataHandler.Instance.PlayerName = nameInput.text;
        Debug.Log("Name1: " + PlayerDataHandler.Instance.PlayerName);
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
