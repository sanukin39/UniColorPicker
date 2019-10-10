# UniColorPicker

## Overview
Simple Color Picker For Unity. It works on uGUI and support movile platforms.

## Demo

## Requirement
Unity 2017 or higher

## Usage
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
use unitypackage at release page

## Licence
MIT

## Author
sanukin39
