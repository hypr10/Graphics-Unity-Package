using UnityEditor;
using UnityEngine;

namespace Vobling.Core.UI
{
    [CustomEditor(typeof(DMMCanvas))]
    public class DMMCanvasEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DMMCanvas dmmCanvas = (DMMCanvas)target;

            if (GUILayout.Button("Adjust"))
            {
                //Record DMM Scale adjustment Undo operation
                Undo.RecordObject(dmmCanvas.transform, "Adjust DMM scale");
                dmmCanvas.Adjust();
            }
            GUILayout.Space(15);
            GUILayout.TextArea("Adjusts the canvas scale so that one canvas unit is equal to one millimeter at one meters distance. Useful to set a standard for readability in VR. This makes all elements with the same height/width equally readable in all viewing distances",
                GUILayout.ExpandHeight(true));
            GUILayout.Space(5);
            if (GUILayout.Button("Read more here"))
            {
                Application.OpenURL("https://www.ryanhinojosa.com/2018/01/08/device-independent/");
            }
        }
    }
}