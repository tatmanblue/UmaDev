using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TatmanGames.Character.Character.Demo
{
    public class ApplicationControl : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            if (true == Input.GetKey(KeyCode.Escape))
            {
                if (SceneManager.GetActiveScene().name.Contains("Menu"))
                    Application.Quit(0);
                else
                    SceneManager.LoadScene("Menu");
            }
        }

        public void ShowScene(int id)
        {
            switch (id)
            {
                case 1:
                    SceneManager.LoadScene("CustomController");
                    break;
                case 2:
                    SceneManager.LoadScene("UMAController");
                    break;
                case 3:
                    SceneManager.LoadScene("UnityController");
                    break;
                default:
                    break;
            }
        }
    }
}