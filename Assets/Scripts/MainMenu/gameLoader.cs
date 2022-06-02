using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameLoader : MonoBehaviour
{
    [SerializeField] string whichScene="Game";
    [SerializeField] bool withLoadingBar = false;

    [SerializeField] GameObject loadingPanel = null;
    [SerializeField] Slider loadingBar = null;
    [SerializeField] Text loadingText = null;

    public void LoadScene()
    {
        if (withLoadingBar)
        {
            StartCoroutine(LoadSceneAsync(whichScene));
        }
        else
        {
            SceneManager.LoadScene(whichScene);
        }
    }

    IEnumerator LoadSceneAsync(string whichScene)
    {
        loadingPanel.SetActive(true);

        AsyncOperation op = SceneManager.LoadSceneAsync(whichScene);

        while (!op.isDone)
        {
            float progress = Mathf.Clamp01(op.progress / .9f);

            loadingBar.value = progress;
            loadingText.text = progress * 100f + "%";

            yield return null;
        }
    }
}
