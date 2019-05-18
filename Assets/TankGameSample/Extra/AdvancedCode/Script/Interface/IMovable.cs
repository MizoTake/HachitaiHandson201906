using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extra.AdvancedCode
{
    public interface IMovable
    {
        void Forward();
        void Back();
        void Left();
        void Right();
    }
}