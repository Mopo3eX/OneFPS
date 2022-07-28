using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace OneFPS
{
    class OneFPS : MonoBehaviour
    {
        public void OnApplicationFocus(bool hasFocus)
        {
            if(hasFocus)
                Application.targetFrameRate = 144;
            else
                Application.targetFrameRate = 10;
        }
    }
}
