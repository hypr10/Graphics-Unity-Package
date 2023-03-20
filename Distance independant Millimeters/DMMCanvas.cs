using UnityEditor;
using UnityEngine;

/*
Adjusts a canvas or other object to a size that is consistant independant of distance from camera according to Googles DistanceDependantMillimeters
Read more about Googles DMM system https://www.ryanhinojosa.com/2018/01/08/device-independent/#:~:text=Introducing%20the%20DMM%3A%20Distance%2DIndependent,multiplying%20the%20DMMs%20by%20distance.
Watch Thor talk about the script: https://drive.google.com/file/d/1O4pb_b8Hxv9ebZX99wFOV2ebiPqwhjKQ/view?usp=sharing

Author: THOR
*/
namespace Vobling.Core.UI
{
    public class DMMCanvas : MonoBehaviour
    {
        //If the player moves relative to the object, call this to re-calculate size. 
        [ContextMenu("Update canvas to DMM")]
        public void Adjust()
        {
            //Adjust object scale
            transform.localScale = Vector3.one * (Vector3.Distance(Camera.main.transform.position, transform.position) / 1000f);

            Debug.Log("Adjusted " + gameObject.name + " to 1DMM");
        }
    }
}