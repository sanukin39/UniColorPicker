# UniColorPicker

## Overview
Simple Color Picker For Unity. It works on uGUI and supports mobile platforms.

## Demo
![Demo](https://github.com/sanukin39/UniColorPicker/blob/master/Demo/colorpickerdemo.gif)

## Requirement
Unity 2017 or higher

## Usage
### Add color picker to scene
Add UniColorPicker/UniColorPicker.prefab into canvas at scene.

### How to get/set color
```csharp
using UniColorPicker;
using UnityEngine;

public class ColorPickerExample : MonoBehaviour
{
    [SerializeField] ColorPicker _colorPicker = null;

    void Example()
    {
        // Set Color To Picker
        var initialColor = Color.red;
        _colorPicker.Color = initialColor;
        
        // Get Color From Picker
        var editedColor = _colorPicker.Color;
    }
}
```

## Install
use unitypackage at [release](https://github.com/sanukin39/UniColorPicker/releases/) page

## Licence
[MIT](https://github.com/sanukin39/UniColorPicker/blob/master/LICENSE)

## Author
[sanukin39](https://github.com/sanukin39)
