using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuControlScript : MonoBehaviour
{
  
        
        // Use this for initialization
        void Start()
        {
        
    }

        // Update is called once per frame
        void Update()
        {
             }

        public void StartButtonClick(Button button)
        {
             SceneManager.LoadScene("SceneGameplay");
             }

        public void StartButtonClick2(Button button)
        {
            SceneManager.LoadScene("SceneGameplay2");
        }

        public void StartButtonClick3(Button button)
        {
            SceneManager.LoadScene("SceneGameplay3");
        }



    public void OptionsButtonClick(Button button)
        {
             if (!SingletonGameApplicationManager.Instance.IsOptionMenuActive)
                 {
                 SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
                 SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
                 }
             }

        public void ExitButtonClick(Button button)
        {
             Application.Quit();
             }
 
}
