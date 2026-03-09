using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadByNameScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadSceneFromButton()
    {
        GameObject currentButton = EventSystem.current.currentSelectedGameObject;

        if (currentButton != null)
        {
            string sceneName = currentButton.name;
            Debug.Log($"Загрузка сцены: {sceneName}");
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Не удалось определить нажатую кнопку!");
        }
    }
}