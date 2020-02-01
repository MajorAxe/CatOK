using System;
using UnityEditor;
using UnityEngine;

    [CustomEditor(typeof(RoadTilesEditor))]
    public class RoadTilesEditor : UnityEditor.Editor
    {
        [MenuItem("Tools/Road tiles/Move negative (x) #a")]
        static void MenuMoveNegX()
        {
            foreach (var t in Selection.transforms) {
                Undo.RecordObject(t, "Move " + t.name);
                var position = t.position;
                var positionX = (int) position.x;
                positionX -= 3 - positionX % 3;
                t.position = new Vector3(positionX, position.y, position.z);
                Debug.Log("Moving " + t.name + " to negative x.");
            }
        }
        
        [MenuItem("Tools/Road tiles/Move positive (x) #d")]
        static void MenuMovePosX()
        {
            foreach (var t in Selection.transforms) {
                Undo.RecordObject(t, "Move " + t.name);
                var position = t.position;
                var positionX = (int) position.x;
                positionX += 3 - positionX % 3;
                t.position = new Vector3(positionX, position.y, position.z);
                Debug.Log("Moving " + t.name + " to positive x.");
            }
        }
        
        [MenuItem("Tools/Road tiles/Move positive (z) #w")]
        static void MenuMovePosZ()
        {
            foreach (var t in Selection.transforms) {
                Undo.RecordObject(t, "Move " + t.name);
                var position = t.position;
                var positionZ = (int) position.z;
                positionZ += 3 - positionZ % 3;
                t.position = new Vector3(position.x, position.y, positionZ);
                Debug.Log("Moving " + t.name + " to positive z.");
            }
        }
        
        [MenuItem("Tools/Road tiles/Move negative (z) #s")]
        static void MenuMoveNegZ()
        {
            foreach (var t in Selection.transforms) {
                Undo.RecordObject(t, "Move " + t.name);
                var position = t.position;
                var positionZ = (int) position.z;
                positionZ -= 3 - positionZ % 3;
                t.position = new Vector3(position.x, position.y, positionZ);
                Debug.Log("Moving " + t.name + " to positive z.");
            }
        }
        
        [MenuItem("Tools/Road tiles/Move positive (y) #r")]
        static void MenuMovePosY()
        {
            foreach (var t in Selection.transforms) {
                Undo.RecordObject(t, "Move " + t.name);
                var position = t.position;
                var mod = position.y % 1.1f;
                if (Math.Abs(mod) < 0.01 || Math.Abs(mod - 1.1f) < 0.01)
                {
                    mod = 0;
                }
                position.y += 1.1f - mod;
                t.position = new Vector3(position.x, position.y, position.z);
                Debug.Log("Moving " + t.name + " to positive y.");
            }
        }
        
        [MenuItem("Tools/Road tiles/Move negative (y) #c")]
        static void MenuMoveNegY()
        {
            foreach (var t in Selection.transforms) {
                Undo.RecordObject(t, "Move " + t.name);
                var position = t.position;
                var mod = position.y % 1.1f;
                if (Math.Abs(mod) < 0.01 || Math.Abs(mod - 1.1f) < 0.01)
                {
                    mod = 0;
                }

                position.y -= 1.1f - mod;
                t.position = new Vector3(position.x, position.y, position.z);
                Debug.Log("Moving " + t.name + " to negative y.");
            }
        }
        
        [MenuItem("Tools/Road tiles/Rotate ccw (around y) #q")]
        static void MenuRotateCcw()
        {
            foreach (var t in Selection.transforms) {
                Undo.RecordObject(t, "Rotate " + t.name);
                t.RotateAround(t.position, Vector3.up, 90);
                Debug.Log("Rotating " + t.name + " clockwise around y.");
            }
        }
        
        [MenuItem("Tools/Road tiles/Rotate cw (around y) #e")]
        static void MenuRotateCw()
        {
            foreach (var t in Selection.transforms) {
                Undo.RecordObject(t, "Rotate " + t.name);
                t.RotateAround(t.position, Vector3.up, -90);
                Debug.Log("Moving " + t.name + " counter clockwise around y..");
            }
        }
    }
