using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Имя сцены которую надо перезапустить
    public string sceneName;
    
    void OnTriggerEnter()
    {
        // Перезапуск сцены
        EditorSceneManager.LoadScene(sceneName);
    }

    
}
