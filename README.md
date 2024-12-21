
# Image Edge Detection Project


## Overview

This project is a simple edge detection tool built using OpenCV and C#. It processes an input image, applies edge detection using user-defined thresholds, and saves the processed image to an output directory.

## Features

- Reads an input image from a predefined folder.
- Uses OpenCV's `Canny` method for edge detection.
- Allows customization of thresholds for edge detection.
- Outputs the processed image with a user-defined name.
- Logs the process for debugging and tracking.


## Example Execution
Add your input image as input.jpg in the Images/ folder.
Modify the code in Program.cs to call the RenderOutputImage method:
csharp
Copy code
```csharp
EdgeDetector.RenderOutputImage("output.jpg", 100, 200);
```
Run the application:
bash
Copy code
dotnet run
The processed image (output.jpg) will appear in the Images/ folder.
