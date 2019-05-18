using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extra.AdvancedCode
{
    public class InputController : MonoBehaviour
    {
        
        private IFirable fireableObject;
        private IMovable movableObject;
        
        // Start is called before the first frame update
        void Start()
        {
            fireableObject = GetComponent<IFirable>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fireableObject.Fire();
            }
        }
    }
}