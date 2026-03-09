using UnityEngine;

public class CanvasToggler : MonoBehaviour
{
    [Header("Настройки")]
    [Tooltip("Перетащите сюда объект Canvas, который нужно скрывать/показывать")]
    public GameObject targetCanvas;

    // Этот метод будет вызываться кнопкой
    private void Start()
    {
        bool currentState = false;
    }
    public void ToggleCanvas()
    {
        if (targetCanvas != null)
        {
            // Инвертируем текущее состояние (если включено -> выключить, и наоборот)
            bool currentState = targetCanvas.activeSelf;
            targetCanvas.SetActive(!currentState);
            Debug.LogWarning("Переключено");
        }
        else
        {
            Debug.LogWarning("Ошибка: Canvas не назначен в инспекторе!");
        }
    }
}