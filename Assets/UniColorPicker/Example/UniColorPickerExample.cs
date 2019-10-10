using UnityEngine;

namespace UniColorPicker.Example
{
    public class UniColorPickerExample : MonoBehaviour
    {
        [SerializeField] private ColorPicker _colorPicker = null;
        [SerializeField] private Camera _camera = null;

        void Awake()
        {
            _colorPicker.Color = Color.cyan;
        }

        void Update()
        {
            _camera.backgroundColor = _colorPicker.Color;
        }
    }
}
