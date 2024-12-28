using EdgeDetectionApp;
using EdgeDetectionApp.Enums;

// Render Images as png type
EdgeDetector.RenderOutputImage($"output1.{Enum.GetName(ImageTypeExtention.png)}", 300, 90);
EdgeDetector.RenderOutputImage($"output2.{Enum.GetName(ImageTypeExtention.png)}", 500, 250);

// Render Images as jpg type
EdgeDetector.RenderOutputImage($"output1.{Enum.GetName(ImageTypeExtention.jpg)}", 400, 90);
EdgeDetector.RenderOutputImage($"output2.{Enum.GetName(ImageTypeExtention.jpg)}", 700, 200);





