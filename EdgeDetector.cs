using OpenCvSharp;

namespace EdgeDetectionApp
{
	internal static class EdgeDetector
	{
        public const string InputImageName = "input.jpg";
        public const string InputImageFolder = "Images";
        /// <summary>
        /// Applies edge detection with specific thresholds and saves the output 1 or 2
        /// </summary>
        public static void RenderOutputImage(string outputName, double treshold1, double treshold2)
		{
			string inputImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, InputImageFolder, InputImageName);
			string outputImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, InputImageFolder, outputName);
			var egdeDetection = Cv2.ImRead(inputImagePath);
			if (egdeDetection.Empty())
			{
				Console.WriteLine($"Could not Find Image as input in the Directory : {inputImagePath}");
				return;
			}
			var edgeDetectedImage = new Mat();
			Cv2.Canny(egdeDetection, edgeDetectedImage, treshold1, treshold2);

			// Save the processed image as output
			Cv2.ImWrite(outputImagePath, edgeDetectedImage);
			Console.WriteLine($"Edge detection {outputName} saved to: {outputImagePath}");
		}
	}
}
