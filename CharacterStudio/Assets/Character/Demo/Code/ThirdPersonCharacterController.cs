using System;
using UnityEngine;

namespace TatmanGames.Character.Character.Demo.Code
{
    public class ThirdPersonCharacterController : MonoBehaviour
    {
        public CharacterController Controller;

        public float Speed = 6f;
        
        private void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                Controller.Move(direction * Speed * Time.deltaTime);
            }
        }
    }
}