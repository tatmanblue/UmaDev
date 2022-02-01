using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TatmanGames.Character.Character.Demo
{
    public class ApplicationControl : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (true == Input.GetKey(KeyCode.Escape))
                Application.Quit(0);
        }
    }
}