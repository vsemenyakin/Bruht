using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    void Start() {
        _restartButton.onClick.AddListener(restartLevel);
    }

    void restartLevel() {
        SceneManager.LoadScene("GameLevel"); //Load scene called Game
        gameObject.SetActive(false);
        unpause();
    }

    public void showAsWin() {
        gameObject.SetActive(true);
        _resultImage.sprite = _winImage;
        pause();
    }

    public void showAsLoose() {
        gameObject.SetActive(true);
        _resultImage.sprite = _looseImage;
        pause();
    }

    void pause() {
        Time.timeScale = 0;
    }

    void unpause() {
        Time.timeScale = 1;
    }

    [SerializeField]
    private UnityEngine.UI.Button _restartButton = null;

    [SerializeField]
    private UnityEngine.UI.Image _resultImage = null;

    [SerializeField]
    private Sprite _winImage = null;

    [SerializeField]
    private Sprite _looseImage = null;
}
